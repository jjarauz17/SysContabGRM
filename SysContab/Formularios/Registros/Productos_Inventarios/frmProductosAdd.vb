Imports System.ComponentModel
Imports ClasesBLL
Imports DevExpress.XtraEditors.Controls

Public Class frmProductosAdd

    Dim r As New VB.SysContab.Rutinas
    Public save As Boolean = False
    Private PVDolar As Double = 0
    'Dim Grupos As New VB.SysContab.Grupos_InventarioDB

    Private Sub frmProductosAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        CargarCombos()
        '
        If Nuevo = "NO" Then

            Dim Detalles As VB.SysContab.ArticulosDetails = VB.SysContab.ArticulosDB.GetDetails(Registro, "P")

            txtCodigo.Text = Detalles.Codigo
            txtCodigo.ReadOnly = True
            txtNombre.Text = Detalles.Nombre
            txtCodigoParte.Text = Detalles.Codigo_Parte
            txtNombreProveedor.Text = Detalles.Nombre_Proveedor
            'Cod_Proveedor = Detalles.Proveedor
            'Me.cbLinea.SelectedValue = Detalles.Linea

            LookUp(cbGrupo, ObtieneDatos("sp_sel_GruposProductos", Detalles.Linea, EmpresaActual), "Nombre", "Codigo", "[Seleccione Grupo]", 0)
            LookUp(cbSubGrupo, ObtieneDatos("sp_sel_SubGruposProductos", Detalles.Grupo, EmpresaActual), "Nombre", "Codigo", "[Seleccione Sub Grupo]", 0)

            'cbGrupo.DataSource = VB.SysContab.Grupos_InventarioDB.Grupos(Detalles.Linea, "P").Tables("GruposCC")
            'cbGrupo.ValueMember = "Código"
            'cbGrupo.DisplayMember = "Nombre"

            'Me.cbGrupo.SelectedValue = Detalles.Grupo

            'cbSubGrupo.DataSource = VB.SysContab.Grupos_InventarioDB.SubGrupos(Detalles.Grupo, "P").Tables("GruposCC")
            'cbSubGrupo.ValueMember = "Código"
            'cbSubGrupo.DisplayMember = "Nombre"

            'Me.cbS_subgrupo.DataSource = Grupos.S_SubGrupos(Detalles.SubGrupo, "P").Tables("GruposCC")
            'Me.cbS_subgrupo.DisplayMember = "Nombre"
            'Me.cbS_subgrupo.ValueMember = "Código"

            'Me.cbProveedor.SelectedValue = Detalles.Proveedor
            Me.cbProveedores.EditValue = CInt(Detalles.Proveedor)

            'Grupos
            'Me.cbSubGrupo.SelectedValue = Detalles.SubGrupo
            cbLinea.EditValue = Detalles.Linea
            cbGrupo.EditValue = Detalles.Grupo
            cbSubGrupo.EditValue = Detalles.SubGrupo
            ' Me.cbS_subgrupo.SelectedValue = Detalles.S_SubGrupo

            'If Me.cbS_subgrupo.Items.Count > 0 Then

            Me.txtModelo.Text = Detalles.Modelo
            ' Me.txtUnidad.Text = Detalles.Unidad
            cbUnidad.EditValue = Detalles.Unidad
            Me.txtPresentacion.Text = Detalles.Presentacion
            Me.txtUbicacion.Text = Detalles.Ubicacion
            cbCentroCosto.EditValue = CInt(Detalles.CentroCosto)
            cbFabricante.EditValue = Detalles.IdFabricante

            ''PARA LOS MEDICAMENTOS
            'Me.txtConcentracion.Text = Detalles.Concentracion
            'Me.txtvia_admini.Text = Detalles.via_administracion
            'Me.txtnivel_uso.Text = Detalles.nivel_uso
            'Me.txtreceta.Text = Detalles.receta
            '--------------------
            Me.txtPVCordoba.EditValue = CDbl(Detalles.Precio_Venta_Cordobas)
            Me.txtPrecoio2.EditValue = CDbl(Detalles.Precio_Venta2)

            'Me.txtPVDolar.Text = CDbl(Detalles.Precio_Venta_Dolar).ToString(RoundP)
            PVDolar = Detalles.Precio_Venta_Dolar
            Me.txtCosto.EditValue = CDbl(Detalles.Costo)
            Me.txtCosto2.EditValue = CDbl(Detalles.Costo2)
            Me.txtMargen.EditValue = CDbl(Detalles.Margen)
            Me.txtCostoPromedio.Text = CDbl(Detalles.Costo_Prom)
            Me.txtCostoUltimo.Text = CDbl(Detalles.Costo_Ultimo)
            Me.txtExistencias.Text = Detalles.Existencia
            Me.txtStockMin.Text = Detalles.Stock_Min
            Me.txtStockMax.Text = Detalles.Stock_Max

            'Me.txtDescuentoA.Text = CDbl(Detalles.Descuento_A).ToString(RoundP)
            'Me.txtDescuentoB.Text = CDbl(Detalles.Descuento_B).ToString(RoundP)
            'Me.txtDescuentoC.Text = CDbl(Detalles.Descuento_C).ToString(RoundP)
            'Max = CDbl(Detalles.Descuento_Maximo).ToString(RoundP)
            'Me.txtTasaCambio.Text = Detalles.Tasa_Cambio
            'Me.txtcodigoproveedor.Text = Detalles.SKU

            Me.cbCultivos.EditValue = Detalles.Cultivo

            'Me.txtInventarioCosto.EditValue = (CDbl(txtCostoPromedio.Text).ToString(RoundP) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
            'Me.txtInventarioVenta.EditValue = (CDbl(Me.txtPVCordoba.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)

            Me.chkExento.Checked = Detalles.Exento
            'Me.cbCatalogo.SelectedValue = Detalles.Cuenta
            Me.cbCatalogo1.EditValue = Detalles.Cuenta
            Me.cbCatalogo2.EditValue = Detalles.CCosto
            Me.cbCatalogo3.EditValue = Detalles.CIngreso
            Me.cbCatalogo4.EditValue = Detalles.CDevolucion
            Me.cbCatalogo5.EditValue = Detalles.CRebaja

            cmbmoneda.EditValue = Detalles.Moneda
            txtFactor.EditValue = Detalles.Factor
            txtFactorIngreso.EditValue = Detalles.FactorIngreso
            txtSAC.Text = Detalles.SAC
            chkActivo.Checked = Detalles.Activo
            chkValidar.Checked = Detalles.Validar_Precio
            chkObsoleto.Checked = Detalles.Obsoleto
            txtMarca.Text = Detalles.Marca
            txtUrl.Text = Detalles.Url

            If Detalles.Foto IsNot Nothing Then pFoto.Image = Bytes2Image(Detalles.Foto)

            'cbProyectos.EditValue = Detalles.IdProyecto
            'CargarDocumentos()
            ' CargarPDF()
        Else

            txtPVCordoba.EditValue = 0.0
            txtPrecoio2.EditValue = 0.0
            'Me.txtPVDolar.Text = CDbl(0).ToString(RoundP)
            txtCosto.EditValue = 0.0
            txtCosto2.EditValue = 0.0
            txtMargen.EditValue = 0.0
            txtCostoPromedio.EditValue = 0.00
            txtCostoUltimo.EditValue = 0.00
            txtExistencias.EditValue = 0.00
            txtStockMin.EditValue = 0.00
            txtStockMax.EditValue = 0.00

            'Me.txtDescuentoA.Text = CDbl(0).ToString(RoundP)
            'Me.txtDescuentoB.Text = CDbl(0).ToString(RoundP)
            'Me.txtDescuentoC.Text = CDbl(0).ToString(RoundP)
            'Max = CDbl(Detalles.Descuento_Maximo).ToString(Round)
            'Me.txtTasaCambio.Text = CDbl(0).ToString(RoundP)

            'Me.txtInventarioCosto.EditValue = CDbl(0.0).ToString(RoundP)
            'Me.txtInventarioVenta.EditValue = CDbl(0.0).ToString(RoundP)
        End If

        ' CargarDocumentos()

        'r.ComboAutoComplete(Me.cbLinea)
        'r.ComboAutoComplete(Me.cbGrupo)
        'r.ComboAutoComplete(Me.cbSubGrupo)
    End Sub

    Private Sub frmProductosAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If save Then
            Dim frm As frmArticulos = frmArticulos.Instance()
            If frm.Created Then frm.Cargar()
        End If
    End Sub

    Sub CargarCombos()

        GetMonedasList(cmbmoneda)
        GetTipoCultivo(cbCultivos)

        LookUp(cbUnidad, db_UnidadesMedida.Listar(0), "Unidad", "Unidad", "[Seleccion U/M]", 0)
        LookUp(cbFabricante, db_Articulos_Fabricantes.Listar(0), "Nombre", "IdFabricante", "[Fabricante]", 0)
        cbFabricante.Properties.ShowHeader = True
        'cbFabricante.Properties.SearchMode = SearchMode.AutoComplete

        Dim DT_CAT As DataTable = ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual)

        GridLookUp(cbCatalogo1, DT_CAT, "Display", "Cuenta", 3, 1, 0)
        GridLookUp(cbCatalogo2, DT_CAT, "Display", "Cuenta", 3, 1, 0)
        GridLookUp(cbCatalogo3, DT_CAT, "Display", "Cuenta", 3, 1, 0)
        GridLookUp(cbCatalogo4, DT_CAT, "Display", "Cuenta", 3, 1, 0)
        GridLookUp(cbCatalogo5, DT_CAT, "Display", "Cuenta", 3, 1, 0)


        GetCatalogoCuenta(Me.cbCatalogo1, vCat1)
        'GetCatalogoCuenta(Me.cbCatalogo2, vCat2)
        'GetCatalogoCuenta(Me.cbCatalogo3, vCat3)
        'GetCatalogoCuenta(Me.cbCatalogo4, vCat4)
        'GetCatalogoCuenta(Me.cbCatalogo5, vCat5)

        GetCatalogoProveedores(cbProveedores, GridView1)
        GetCentrosCostosList(cbCentroCosto, 1)
        '
        LookUp(cbLinea, ObtieneDatos("sp_sel_LineasProductos", EmpresaActual), "Nombre", "Codigo", "[Seleccione Linea]", 0)

        'cbLinea.DataSource = VB.SysContab.Grupos_InventarioDB.Lineas("P").Tables("GruposCC")
        'cbLinea.ValueMember = "Código"
        'cbLinea.DisplayMember = "Nombre"
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        'If Me.cbLinea.SelectedValue = "%" And Me.cbLinea.Text.Length = 0 Then
        '    XtraMsg("Seleccione la Linea", MessageBoxIcon.Warning)
        '    cbLinea.Focus()
        '    Exit Sub
        'End If
        ''
        'If Me.cbGrupo.SelectedValue = "%" And Me.cbGrupo.Text.Length = 0 Then
        '    XtraMsg("Seleccione el Grupo")
        '    cbGrupo.Focus()
        '    Exit Sub
        'End If
        '
        If Nuevo = "SI" Then
            If chkExento.Checked Then
                If Not XtraMsg2("Esta Seguro que el Nuevo Producto es Exento de Impuesto?") Then
                    chkExento.Focus()
                    Exit Sub
                End If
            End If
        End If
        '
        If Not (VB.SysContab.ArticulosDB.GetDetails(txtCodigo.Text, "P").Codigo Is Nothing) And Nuevo = "SI" Then
            XtraMsg("Ese codigo ya existe", MessageBoxIcon.Error)
            txtCodigo.SelectAll()
            txtCodigo.Focus()
            Exit Sub
        End If
        '
        Guardar()
    End Sub

    Private Sub Guardar()

        Dim Articulo As New VB.SysContab.ArticulosDB


        Dim Exento As Integer

        If chkExento.Checked = True Then
            Exento = 1
        Else
            Exento = 0
        End If

        'Dim Cultivo As String = ""
        'If ObtieneDatos("SELECT * FROM TipoCultivo WHERE Empresa = " & EmpresaActual).Rows.Count > 0 Then
        '    Cultivo = Me.cbCultivos.EditValue
        'End If

        Dim Foto As Byte() = Nothing
        If Not IsNothing(pFoto.EditValue) Then Foto = ImageBytes(pFoto.Image)

        If Nuevo = "SI" Then
            Articulo.AddItem(txtCodigo.Text, txtNombre.Text, cbProveedores.EditValue, cbLinea.EditValue,
                             cbGrupo.EditValue, IsNull(cbSubGrupo.EditValue, ""),
                             "0", txtModelo.Text,
                             IIf(cbUnidad.EditValue Is Nothing, "", cbUnidad.EditValue), txtPresentacion.Text, txtUbicacion.Text,
                             txtPVCordoba.EditValue, PVDolar, txtCosto.EditValue,
                             Me.txtMargen.EditValue, txtCostoPromedio.EditValue, txtCostoUltimo.EditValue, txtExistencias.EditValue, txtStockMin.EditValue,
                             txtStockMax.EditValue, 0, 0, 0, 0, 1, "P",
                             Exento, IIf(Me.cbCatalogo1.EditValue Is Nothing, "", Me.cbCatalogo1.EditValue),
                             "", "", "", "",
                             cmbmoneda.EditValue, "", cbCultivos.EditValue, IIf(Me.cbCatalogo2.EditValue Is Nothing, "", Me.cbCatalogo2.EditValue),
                             IIf(Me.cbCatalogo3.EditValue Is Nothing, "", Me.cbCatalogo3.EditValue), Me.txtFactor.EditValue,
                             IIf(Me.cbCatalogo4.EditValue Is Nothing, "", Me.cbCatalogo4.EditValue), IIf(Me.cbCatalogo5.EditValue Is Nothing, "", Me.cbCatalogo5.EditValue),
                             IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue), txtSAC.Text, IIf(chkActivo.Checked, 1, 0),
                             IIf(chkValidar.Checked, 1, 0), IIf(chkObsoleto.Checked, 1, 0), txtPrecoio2.EditValue, txtCosto2.EditValue, 0,
                             txtCodigoParte.Text, txtNombreProveedor.Text,
                             IIf(cbFabricante.EditValue Is Nothing, 0, cbFabricante.EditValue), txtFactorIngreso.EditValue, txtMarca.Text,
                             txtUrl.Text, Foto)

            XtraMsg("El Producto : " & txtCodigo.Text + " ha sido registrado con éxito!")
            '
            Limpiar()
            save = True
        Else
            Articulo.Update(txtCodigo.Text, txtNombre.Text, Me.cbProveedores.EditValue, cbLinea.EditValue,
                            cbGrupo.EditValue, IsNull(cbSubGrupo.EditValue, ""),
                            "0", txtModelo.Text,
                            IIf(cbUnidad.EditValue Is Nothing, "", cbUnidad.EditValue), txtPresentacion.Text, txtUbicacion.Text, Me.txtPVCordoba.EditValue, 0, Me.txtCosto.EditValue,
                            Me.txtMargen.EditValue, txtExistencias.EditValue, txtStockMin.EditValue, txtStockMax.EditValue, 0,
                            0, 0, 0, 1, chkExento.Checked,
                            IIf(Me.cbCatalogo1.EditValue Is Nothing, "", Me.cbCatalogo1.EditValue), "",
                            "", "", "", "P", cmbmoneda.EditValue,
                            "", cbCultivos.EditValue, IIf(Me.cbCatalogo2.EditValue Is Nothing, "", Me.cbCatalogo2.EditValue),
                            IIf(Me.cbCatalogo3.EditValue Is Nothing, "", Me.cbCatalogo3.EditValue), Me.txtFactor.EditValue,
                            IIf(Me.cbCatalogo4.EditValue Is Nothing, "", Me.cbCatalogo4.EditValue), IIf(Me.cbCatalogo5.EditValue Is Nothing, "", Me.cbCatalogo5.EditValue),
                            IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue), txtSAC.Text, IIf(chkActivo.Checked, 1, 0),
                            IIf(chkValidar.Checked, 1, 0), IIf(chkObsoleto.Checked, 1, 0), txtPrecoio2.EditValue, txtCosto2.EditValue, 0,
                            txtCodigoParte.Text, txtNombreProveedor.Text, IIf(cbFabricante.EditValue Is Nothing, 0, cbFabricante.EditValue),
                            txtFactorIngreso.EditValue, txtMarca.Text,
                            txtUrl.Text, Foto)

            save = True
            Close()
        End If
    End Sub

    Private Sub Limpiar()

        Me.txtCosto.EditValue = 0.0
        Me.txtCosto2.EditValue = 0.0
        Me.txtMargen.EditValue = 0.0
        Me.txtCostoPromedio.EditValue = 0.00
        Me.txtCostoUltimo.EditValue = 0.00
        Me.txtPVCordoba.EditValue = 0.0
        Me.txtPrecoio2.EditValue = 0.0
        PVDolar = 0.00
        'Me.txtPVDolar.Text = "0.00"
        'Me.txtDescuentoA.Text = "0.00"
        'Me.txtDescuentoB.Text = "0.00"
        'Me.txtDescuentoC.Text = "0.00"
        Me.txtStockMax.EditValue = 0.00
        Me.txtStockMin.EditValue = 0.00
        Me.txtCodigo.Text = ""
        Me.txtExistencias.EditValue = 0.00
        'Me.txtInventarioCosto.EditValue = 0.0
        'Me.txtInventarioVenta.EditValue = 0.0
        Me.txtModelo.Text = ""
        Me.txtNombre.Text = ""
        Me.txtPresentacion.Text = ""
        Me.txtUbicacion.Text = ""
        'Me.txtUnidad.Text = ""
        cbUnidad.EditValue = ""
        'Me.txtConcentracion.Text = ""
        'Me.txtvia_admini.Text = ""
        'Me.txtnivel_uso.Text = ""
        'Me.txtreceta.Text = ""
        txtFactor.EditValue = 1.0
        txtFactorIngreso.EditValue = 1.0
        txtSAC.Text = ""
        'Me.txt.Text = ""

        'Me.cbProveedor.SelectedIndex = -1
        cbProveedores.EditValue = 0
        'cbLinea.SelectedIndex = -1
        'Me.cbCatalogo.SelectedIndex = -1
        cbCatalogo1.EditValue = Nothing
        cbCatalogo2.EditValue = Nothing
        cbCatalogo3.EditValue = Nothing
        cbCatalogo4.EditValue = Nothing
        cbCatalogo5.EditValue = Nothing

        'Limpiar Combo de los subgrupos
        'cbGrupo.DataSource = Nothing
        'cbSubGrupo.DataSource = Nothing
        'Me.cbS_subgrupo.DataSource = Nothing

        'cbGrupo.SelectedIndex = -1
        'cbSubGrupo.SelectedIndex = -1
        'Me.cbS_subgrupo.SelectedIndex = -1

        'cbProveedor.SelectedValue = -1
        'cbLinea.SelectedValue = -1
        'cbGrupo.SelectedValue = -1
        'cbSubGrupo.SelectedValue = -1
        'Me.cbS_subgrupo.SelectedValue = -1

        txtCodigo.Focus()
    End Sub

    Private Sub bBodegas_Click(sender As Object, e As EventArgs) Handles bBodegas.Click
        Dim f As frmGridArticulosxBodega = frmGridArticulosxBodega.Instance()
        f.cArticulo = txtCodigo.Text
        f.Text = "PRODUCTO: " + txtCodigo.Text + " - " + txtNombre.Text
        f.TipoProducto = "P"
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub cmdAcumulados_Click(sender As Object, e As EventArgs) Handles cmdAcumulados.Click
        Dim f As frmAcumuladosProductos = frmAcumuladosProductos.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub



    Private Sub txtCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigo.EditValueChanged
        CodigoBarra.Visible = True
        CodigoBarra.BarCode = txtCodigo.Text
    End Sub

    Private Sub txtMargen_Validating(sender As Object, e As CancelEventArgs) Handles txtMargen.Validating, txtCosto.Validating
        Try
            txtPVCordoba.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularPrecioVenta(" & txtCosto.EditValue & "," & txtMargen.EditValue & ") Precio").Rows.Item(0)("Precio")
            PVDolar = 0.00  'IIf(CDbl(txtTasaCambio.Text) = 0, 0, CDbl(CDbl(Me.txtPVCordoba.EditValue) / CDbl(txtTasaCambio.Text)).ToString(RoundP))                       
        Catch ex As Exception
            txtPVCordoba.EditValue = 0.00
            PVDolar = 0.00
        End Try
    End Sub

    Private Sub txtPVCordoba_Validating(sender As Object, e As CancelEventArgs) Handles txtPVCordoba.Validating
        Try
            txtMargen.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularMargenVenta(" & txtCosto.EditValue & "," & txtPVCordoba.EditValue & ") Precio").Rows.Item(0)("Precio")
        Catch ex As Exception
            txtMargen.EditValue = 0.0
        End Try
    End Sub

    Private Sub cbCultivos_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbCultivos.ButtonClick
        If e.Button.Index = 1 Then
            With My.Forms.frmTipoCultivo
                .ShowDialog()
                If .ok = "SI" Then GetTipoCultivo(Me.cbCultivos)
                .Dispose()
            End With
        End If
    End Sub

    Private Sub txtCosto2_Validating(sender As Object, e As CancelEventArgs) Handles txtCosto2.Validating, txtMargen.Validating
        Try
            txtPrecoio2.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularPrecioVenta(" & txtCosto2.EditValue & "," & txtMargen.EditValue & ") Precio").Rows.Item(0)("Precio")
        Catch ex As Exception
            txtPrecoio2.EditValue = 0.0
        End Try
    End Sub

    Private Sub bAdjuntar_Click(sender As Object, e As EventArgs) Handles bAdjuntar.Click
        If Nuevo = "SI" Then
            XtraMsg("Debe Guardar Primero el Producto...")
            Exit Sub
        End If
        '
        With frmDocumentos
            .Tipo = "PRODUCTO"
            .Codigo = txtCodigo.Text
            .NDocumento = txtNombre.Text
            .Text = "Soporte Digital del Producto: " & txtNombre.Text
            .txtNombre.Text = txtNombre.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub cbUnidad_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbUnidad.ButtonClick
        If e.Button.Index = 1 Then
            With frmUnidadMedidaAdd
                .ID = 0
                .ShowDialog()
                If .Ok = "SI" Then LookUp(cbUnidad, db_UnidadesMedida.Listar(0), "Unidad", "Unidad", "[Seleccion U/M]", 0)
                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbFabricante_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbFabricante.ButtonClick
        If e.Button.Index = 1 Then
            With frmFabricantesAdd
                .ID = 0
                .ShowDialog()
                If .Ok = "SI" Then LookUp(cbFabricante, db_Articulos_Fabricantes.Listar(0), "Nombre", "IdFabricante", "[Fabricante]", 0)
                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbLinea_EditValueChanged(sender As Object, e As EventArgs) Handles cbLinea.EditValueChanged
        If Inicio Then Exit Sub
        '
        If Not IsNothing(cbLinea.EditValue) Then


            LookUp(cbGrupo, ObtieneDatos("sp_sel_GruposProductos", IsNull(cbLinea.EditValue, "%"), EmpresaActual), "Nombre", "Codigo", "[Seleccione Grupo]", 0)
            cbGrupo.ItemIndex = 0
            'cbGrupo.DataSource = VB.SysContab.Grupos_InventarioDB.Grupos(cbLinea.SelectedValue, "P").Tables("GruposCC")
            'cbGrupo.ValueMember = "Código"
            'cbGrupo.DisplayMember = "Nombre"
        End If

        'cbSubGrupo.DataSource = Nothing
    End Sub

    Private Sub cbGrupo_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbGrupo_EditValueChanged(sender As Object, e As EventArgs) Handles cbGrupo.EditValueChanged
        If Inicio Then Exit Sub
        '
        If Not IsNothing(cbGrupo.EditValue) Then

            LookUp(cbSubGrupo, ObtieneDatos("sp_sel_SubGruposProductos", IsNull(cbGrupo.EditValue, "%"), EmpresaActual), "Nombre", "Codigo", "[Seleccione Sub Grupo]", 0)
            cbSubGrupo.ItemIndex = 0

            'cbSubGrupo.DataSource = VB.SysContab.Grupos_InventarioDB.SubGrupos(Me.cbGrupo.SelectedValue, "P").Tables("GruposCC")
            'cbSubGrupo.ValueMember = "Código"
            'cbSubGrupo.DisplayMember = "Nombre"
        End If
    End Sub

    Private Sub cbSubGrupo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkValidar_CheckedChanged(sender As Object, e As EventArgs) Handles chkValidar.CheckedChanged

    End Sub

    Private Sub txtMargen_EditValueChanged(sender As Object, e As EventArgs) Handles txtMargen.EditValueChanged

    End Sub

    Private Sub txtPVCordoba_EditValueChanged(sender As Object, e As EventArgs) Handles txtPVCordoba.EditValueChanged

    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles pFoto.EditValueChanged

    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles pFoto.Click
        Dim OpenFile As New OpenFileDialog

        OpenFile.DefaultExt = "*.png"
        OpenFile.Filter = "PNG File (*.png)|*.png| PNG File (*.jpg)|*.jpg"
        '
        If Not OpenFile.ShowDialog = DialogResult.OK Then
            Exit Sub
        End If

        pFoto.Image = Image.FromFile(OpenFile.FileName)
    End Sub
End Class