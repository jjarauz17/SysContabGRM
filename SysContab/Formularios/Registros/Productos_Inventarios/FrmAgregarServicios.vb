Public Class FrmAgregarServicios

    Dim proveedor As String
    Dim linea As String
    Dim grupo As String
    Dim subgrupo As String

    Dim Cod_Proveedor As Integer
    Dim Cod_Grupo As Integer
    Dim Cod_Linea As Integer
    Dim Cod_SubGrupo As Integer
    Dim Cod_S_Subgrupo As String
    Private Catalogos As New VB.SysContab.CatalogoDB()
    Private Shared ChildInstance As FrmAgregarServicios = Nothing
    Private _DT_CABYS As DataTable = New DataTable("CABYS")

    Public Shared Function Instance() As FrmAgregarServicios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmAgregarServicios()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Public PC As String

    Private Sub frmAgregarServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas()
        Dim Servicio As New VB.SysContab.ServiciosDB()
        Dim g As New VB.SysContab.Grupos_InventarioDB()
        Dim p As New VB.SysContab.ProveedoresDB()

        proveedor = ""
        linea = ""
        grupo = ""
        subgrupo = ""

        GetCatalogoCuenta(Me.cbCatalogo, vCat1)
        GetCatalogoProveedores(Me.cbProveedor, GridView1)

        'cbProveedor.DataSource = p.GetListBuscarCombo("%", PC).Tables("PROVEEDORES")
        'cbProveedor.ValueMember = "CODIGO"
        'cbProveedor.DisplayMember = "NOMBRE"

        If PC = "C" Then
            Me.lblProv.Text = "Clientes"
        End If

        cbLinea.DataSource = g.LineasServiciosList().Tables("Grupos_Inventario")
        cbLinea.ValueMember = "Codigo"
        cbLinea.DisplayMember = "Nombre"

        GetCentrosCostosList(cbCentroCosto, 1)

        'Me.cbCatalogo.DataSource = Catalogos.CatalogoList("A", 0).Tables("CATALOGO")
        'Me.cbCatalogo.ValueMember = "Cuenta"
        'Me.cbCatalogo.DisplayMember = "Nombre2"

        '---------------------------------------
        'ESTO NO VA
        'cbGrupo.DataSource = g.GetListBuscarCombo("%", "S").Tables("GRUPOS_INVENTARIO")
        'cbGrupo.ValueMember = "CODIGO_GRUPO"
        'cbGrupo.DisplayMember = "NOMBRE"

        'cbSubGrupo.DataSource = g.GetListBuscarCombo("%", "S").Tables("GRUPOS_INVENTARIO")
        'cbSubGrupo.ValueMember = "CODIGO_GRUPO"
        'cbSubGrupo.DisplayMember = "NOMBRE"

        'cbProveedor.SelectedIndex = -1
        'cbProveedor.SelectedItem = 0
        'cbProveedor.Refresh()
        '-------------------------------------------

        ''r.CambiarEstilo(Me)

        If Nuevo = "NO" Then
            Dim Grupos As New VB.SysContab.Grupos_InventarioDB
            Me.Text = "Editar Servicio"

            Dim Detalles As VB.SysContab.ServiciosDetails = Servicio.GetDetails(Registro, "S", PC)

            Me.txtCodigo.Text = Detalles.Codigo.ToString
            Me.txtNombre.Text = Detalles.Nombre.ToString
            Cod_Proveedor = Detalles.Proveedor.ToString
            Me.cbProveedor.EditValue = Detalles.Proveedor.ToString
            chkKilometraje.Checked = Detalles.Kilometraje
            chkDescuento.Checked = Detalles.Descuento

            'CARGAR COMBO GRUPO
            cbGrupo.DataSource = Grupos.Grupos(Detalles.Linea, "S").Tables("GruposCC")
            cbGrupo.ValueMember = "Código"
            cbGrupo.DisplayMember = "Nombre"
            'CARGAR COMBO SUBGRUPO
            cbSubGrupo.DataSource = Grupos.SubGrupos(Detalles.Grupo, "S").Tables("GruposCC")
            cbSubGrupo.ValueMember = "Código"
            cbSubGrupo.DisplayMember = "Nombre"
            'CARGAR COMBO S-SUBGRUPO
            Me.cbS_subgrupo.DataSource = Grupos.S_SubGrupos(Detalles.SubGrupo, "S").Tables("GruposCC")
            Me.cbS_subgrupo.DisplayMember = "Nombre"
            Me.cbS_subgrupo.ValueMember = "Código"

            'If Detalles.Linea <> "" Or Detalles.Linea <> 0 Then
            '    Me.cbLinea.SelectedValue = Detalles.Linea.ToString
            '    Me.cbGrupo.SelectedValue = Detalles.Grupo.ToString
            '    Me.cbSubGrupo.SelectedValue = Detalles.SubGrupo.ToString
            'End If


            'ASIGAR LOS VALORES CORRESPONDIENTES A CADA GRUPO
            Me.cbLinea.SelectedValue = Detalles.Linea.ToString
            Me.cbGrupo.SelectedValue = Detalles.Grupo.ToString
            Me.cbSubGrupo.SelectedValue = Detalles.SubGrupo.ToString
            Me.cbS_subgrupo.SelectedValue = Detalles.S_SubGrupo.ToString

            cbCentroCosto.EditValue = Detalles.Centro

            'Me.cbS_subgrupo.DataSource = g.S_SubGrupos(Me.cbSubGrupo.SelectedValue.ToString, "S").Tables("GruposCC")
            'Me.cbS_subgrupo.ValueMember = "Código"
            'Me.cbS_subgrupo.DisplayMember = "Nombre"

            'Me.cbS_subgrupo.SelectedValue = Detalles.S_SubGrupo.ToString

            Me.txtCosto.Text = CDbl(Detalles.Costo).ToString(Round)
            Me.txtMargen.Text = CDbl(Detalles.Margen.ToString).ToString(Round)
            Me.txtCostoPromedio.Text = CDbl(Detalles.Costo_Promedio).ToString(Round)
            Me.txtCostoUltimo.Text = CDbl(Detalles.Costo_Ultimo).ToString(Round)

            Me.txtPrecio.Text = CDbl(Detalles.Precio).ToString(Round)
            Me.txtNumeroHoras.Text = Detalles.Numero_Horas.ToString
            Me.txtPrecioHora.Text = CDbl(Detalles.Precio_Hora).ToString(Round)
            Me.txtMinimoHoras.Text = Detalles.Minimo_Horas.ToString
            Me.txtIncremento.Text = CDbl(Detalles.Incremento).ToString(Round)
            Me.txtPrecioMinimo.Text = CDbl(Detalles.Precio_Minimo).ToString(Round)

            txtValorIncremento.Text = ((txtIncremento.Text * txtPrecioHora.Text) / 100) * txtMinimoHoras.Text

            Me.txtDescuentoA.Text = Detalles.Descuento_A.ToString
            Me.txtDescuentoB.Text = Detalles.Descuento_B.ToString
            Me.txtDescuentoC.Text = Detalles.Descuento_C.ToString

            Me.txtTransporte.Text = Detalles.Gasto_Transporte.ToString
            Me.txtMaterial.Text = Detalles.Gasto_Material.ToString
            Me.txtPersonal.Text = Detalles.Gasto_Personal.ToString
            Me.txtExternos.Text = Detalles.Gasto_Externo.ToString

            Me.txtValorTransporte.Text = (Detalles.Precio * Detalles.Gasto_Transporte / 100.0).ToString(Round) 'Detalles.Valor_Transporte
            Me.txtValorMaterial.Text = (Detalles.Precio * Detalles.Gasto_Material / 100.0).ToString(Round)
            Me.txtValorPersonal.Text = (Detalles.Precio * Detalles.Gasto_Personal / 100.0).ToString(Round)
            Me.txtValorExternos.Text = (Detalles.Precio * Detalles.Gasto_Externo / 100.0).ToString(Round)

            Me.cbCatalogo.EditValue = Detalles.Cuenta

            txtCabys.Text = Detalles.Cabys
            txtImpuesto.EditValue = Detalles.Impuesto
            '
            ChkExento.Checked = Detalles.Exento
        Else
            Text = "Agregar Servicio"
        End If
        '
        BuscarImpuesto()
        '
        'Cargar Catalogo CABYS para CR
        _DT_CABYS = ObtieneDatos("sp_sel_CR_CABYS", EmpresaActual)
        '
        Refresh()
    End Sub

    Private Sub cmdCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Servicios As New VB.SysContab.ServiciosDB()

        Dim r As New VB.SysContab.Rutinas()

        If Trim(Me.txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        If Trim(Me.txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        If Me.cbProveedor.EditValue Is Nothing Then
            MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
            Me.cbProveedor.Focus()
            Exit Sub
        End If


        If Me.cbCatalogo.EditValue Is Nothing Or Me.cbCatalogo.EditValue = "" Then
            MsgBox("Debe seleccionar una cuenta contable para el servicio que esta Grabando/Actualizando", MsgBoxStyle.Critical, "STS-Contable")
            Exit Sub
        End If

        If Not (VB.SysContab.ArticulosDB.GetDetails(Me.txtCodigo.Text, "S").Codigo Is Nothing) And Nuevo = "SI" Then
            XtraMsg("Ese codigo ya existe", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        BuscarImpuesto()

        Try
            If Nuevo = "SI" Then

                Servicios.AddItem(txtCodigo.Text, txtNombre.Text, Me.cbProveedor.EditValue,
                                  cbLinea.SelectedValue, cbGrupo.SelectedValue, cbSubGrupo.SelectedValue,
                                  IIf(Me.cbS_subgrupo.SelectedValue = Nothing, "", Me.cbS_subgrupo.SelectedValue),
                                  txtCosto.Text, txtMargen.Text, txtCostoPromedio.Text, txtCostoUltimo.Text,
                                  txtPrecio.Text, txtNumeroHoras.Text, txtPrecioHora.Text, txtMinimoHoras.Text,
                                  txtIncremento.Text, txtPrecioMinimo.Text, txtDescuentoA.Text, txtDescuentoB.Text,
                                  txtDescuentoC.Text, txtTransporte.Text, txtMaterial.Text, txtPersonal.Text,
                                  txtExternos.Text, Me.cbCatalogo.EditValue, ChkExento.Checked, PC, IIf(chkKilometraje.Checked, 1, 0),
                                  IIf(chkDescuento.Checked, 1, 0), IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue),
                                  txtCabys.Text, txtImpuesto.EditValue)

                XtraMsg("El registro ha sido guardado correctamente")

                r.LimpiarControles(GroupBox1)
                r.LimpiarControles(GroupBox4)
                r.LimpiarControles(GroupBox7)
                r.LimpiarControles(GroupBox9)
                r.LimpiarControles(GroupBox10)

                'cbProveedor.EditValue = Nothing
                cbLinea.SelectedValue = -1

                Me.cbGrupo.DataSource = Nothing
                Me.cbSubGrupo.DataSource = Nothing
                Me.cbS_subgrupo.DataSource = Nothing

                cbGrupo.SelectedValue = -1
                cbSubGrupo.SelectedValue = -1

                cbProveedor.EditValue = Nothing
                cbLinea.SelectedValue = -1
                cbGrupo.SelectedValue = -1
                cbSubGrupo.SelectedValue = -1

                txtCodigo.Focus()
                BuscarImpuesto()
            Else
                Servicios.Update(txtCodigo.Text, txtNombre.Text, Me.cbProveedor.EditValue, cbLinea.SelectedValue,
                                 cbGrupo.SelectedValue, cbSubGrupo.SelectedValue,
                                 IIf(Me.cbS_subgrupo.SelectedValue = Nothing, "", Me.cbS_subgrupo.SelectedValue),
                                 CDbl(txtCosto.Text).ToString(Round), CDbl(txtMargen.Text).ToString(Round),
                                 CDbl(txtCostoPromedio.Text).ToString(Round), CDbl(txtCostoUltimo.Text).ToString(Round),
                                 CDbl(txtPrecio.Text).ToString(Round), txtNumeroHoras.Text, CDbl(txtPrecioHora.Text).ToString(Round),
                                 txtMinimoHoras.Text, CDbl(txtIncremento.Text).ToString(Round),
                                 CDbl(txtPrecioMinimo.Text).ToString(Round), txtDescuentoA.Text, txtDescuentoB.Text, txtDescuentoC.Text,
                                 txtTransporte.Text, txtMaterial.Text, txtPersonal.Text, txtExternos.Text, Me.cbCatalogo.EditValue,
                                 ChkExento.Checked, PC, IIf(chkKilometraje.Checked, 1, 0), IIf(chkDescuento.Checked, 1, 0),
                                 IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue),
                                 txtCabys.Text, txtImpuesto.EditValue)
                'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
                Me.Close()
            End If

        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub cbGrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbGrupo.KeyPress
    '    Dim g As New VB.SysContab.Grupos_InventarioDB()

    '    If e.KeyChar = "'" Then
    '        e.Handled = True
    '        Exit Sub

    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            grupo = ""
    '            cbGrupo.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbGrupo.Text = "" Then
    '        grupo = ""
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If grupo.Length = 1 Then
    '            grupo = ""
    '        End If

    '        If grupo.Length > 1 Then
    '            grupo = Mid(grupo, 1, grupo.Length - 1)
    '        End If

    '        If cbGrupo.Text = "" Then
    '            grupo = ""
    '            Exit Sub

    '        End If

    '    Else
    '        grupo = grupo & e.KeyChar

    '    End If

    '    If g.GetListBuscarCombo(grupo, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
    '        '

    '    Else
    '        cbGrupo.SelectedValue = g.GetListBuscarCombo(grupo, "S").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '        cbGrupo.SelectionStart = grupo.Length
    '        cbGrupo.Select(grupo.Length, cbGrupo.Text.Length)

    '    End If

    'End Sub

    'Private Sub cbGrupo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupo.Leave
    '    Dim g As New VB.SysContab.Grupos_InventarioDB()

    '    If Trim(cbGrupo.Text) = "" Then
    '        grupo = ""
    '        Exit Sub
    '    End If

    '    If g.GetListBuscarCombo(cbGrupo.Text, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
    '        MsgBox("Grupo no Existe", MsgBoxStyle.Information)
    '        grupo = ""
    '        cbGrupo.Focus()
    '        Exit Sub

    '    End If

    '    'cbGrupo.SelectedValue = g.GetListBuscarCombo(cbGrupo.Text, "P").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '    Cod_Grupo = g.GetListBuscarCombo(cbGrupo.Text, "S").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")

    '    grupo = ""

    '  End Sub

    Private Sub cbGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedValueChanged
        Dim g As New VB.SysContab.Grupos_InventarioDB

        If Me.cbGrupo.SelectedIndex > 0 Then
            Me.cbSubGrupo.DataSource = g.SubGrupos(Me.cbGrupo.SelectedValue.ToString, "S").Tables("GruposCC")
            Me.cbSubGrupo.ValueMember = "Código"
            Me.cbSubGrupo.DisplayMember = "Nombre"
        End If

        grupo = ""
    End Sub

    'Private Sub cbLinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbLinea.KeyPress
    '    Dim g As New VB.SysContab.Grupos_InventarioDB

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            linea = ""
    '            cbLinea.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbLinea.Text = "" Then
    '        linea = ""
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If linea.Length = 1 Then
    '            linea = ""
    '        End If

    '        If linea.Length > 1 Then
    '            linea = Mid(linea, 1, linea.Length - 1)
    '        End If

    '        If cbLinea.Text = "" Then
    '            linea = ""
    '            Exit Sub

    '        End If

    '    Else
    '        linea = linea & e.KeyChar

    '    End If

    '    If g.GetListBuscarCombo(linea, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
    '        '

    '    Else
    '        cbLinea.SelectedValue = g.GetListBuscarCombo(linea, "S").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '        cbLinea.SelectionStart = linea.Length
    '        cbLinea.Select(linea.Length, cbLinea.Text.Length)

    '    End If

    'End Sub

    'Private Sub cbLinea_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLinea.Leave


    '    Dim g As New VB.SysContab.Grupos_InventarioDB

    '    If Trim(cbLinea.Text) = "" Then
    '        linea = ""
    '        Exit Sub
    '    End If

    '    If g.GetListBuscarCombo(cbLinea.Text, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
    '        MsgBox("Linea no Existe", MsgBoxStyle.Information)
    '        linea = ""
    '        cbLinea.Focus()
    '        Exit Sub

    '    End If

    '    'cbLinea.SelectedValue = g.GetListBuscarCombo(cbLinea.Text, "P").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '    Cod_Linea = g.GetListBuscarCombo(cbLinea.Text, "S").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")

    '    linea = ""

    'End Sub

    Private Sub cbLinea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLinea.SelectedValueChanged
        Dim g As New VB.SysContab.Grupos_InventarioDB

        If Me.cbLinea.SelectedIndex > 0 Then
            Me.cbGrupo.DataSource = g.Grupos(Me.cbLinea.SelectedValue.ToString, "S").Tables("GruposCC")
            Me.cbGrupo.ValueMember = "Código"
            Me.cbGrupo.DisplayMember = "Nombre"
        End If

        Me.cbSubGrupo.DataSource = Nothing
        Me.cbS_subgrupo.DataSource = Nothing

        'If g.GetListBuscarCombo(cbSubGrupo.Text, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
        '    MsgBox("SubGrupo no Existe", MsgBoxStyle.Information)
        '    subgrupo = ""
        '    cbSubGrupo.Focus()
        '    Exit Sub

        'End If

        linea = ""
    End Sub

    'Private Sub cbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbProveedor.KeyPress
    '    Dim p As New VB.SysContab.ProveedoresDB

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            proveedor = ""
    '            cbProveedor.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbProveedor.Text = "" Then
    '        proveedor = ""
    '        Exit Sub

    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If proveedor.Length = 1 Then
    '            proveedor = ""
    '        End If

    '        If proveedor.Length > 1 Then
    '            proveedor = Mid(proveedor, 1, proveedor.Length - 1)
    '        End If

    '        If cbProveedor.Text = "" Then
    '            proveedor = ""
    '            'cbProveedor.Text = ""
    '            Exit Sub
    '        End If
    '    Else
    '        proveedor = proveedor & e.KeyChar

    '    End If

    '    If p.GetListBuscarCombo(proveedor, PC).Tables("PROVEEDORES").Rows.Count = 0 Then
    '        'cbProveedor.SelectedIndex = -1
    '        'cbProveedor.Text = ""
    '        'cbProveedor.SelectionStart = xxx.Length
    '        'cbProveedor.Select(cbProveedor.Text.Length - 1, cbProveedor.Text.Length)
    '        'cbProveedor.Text = xxx

    '    Else
    '        cbProveedor.SelectedValue = p.GetListBuscarCombo(proveedor, PC).Tables("PROVEEDORES").Rows(0).Item("CODIGO")
    '        cbProveedor.SelectionStart = proveedor.Length
    '        cbProveedor.Select(proveedor.Length, cbProveedor.Text.Length)

    '    End If

    'End Sub

    'Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
    '    proveedor = ""
    'End Sub


    'Private Sub cbProveedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.Leave
    '    Dim p As New VB.SysContab.ProveedoresDB

    '    If Trim(cbProveedor.Text) = "" Then
    '        proveedor = ""
    '        Exit Sub
    '    End If

    '    If p.GetListBuscarCombo(cbProveedor.Text, PC).Tables("PROVEEDORES").Rows.Count = 0 Then
    '        MsgBox("Proveedor no Existe", MsgBoxStyle.Information)
    '        proveedor = ""
    '        cbProveedor.Focus()
    '        Exit Sub

    '    End If

    '    'cbProveedor.SelectedValue = p.GetListBuscarCombo(cbProveedor.Text).Tables("PROVEEDORES").Rows(0).Item("CODIGO")
    '    Cod_Proveedor = p.GetListBuscarCombo(cbProveedor.Text, PC).Tables("PROVEEDORES").Rows(0).Item("CODIGO")
    '    proveedor = ""
    'End Sub

    'Private Sub cbSubGrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbSubGrupo.KeyPress
    '    Dim g As New VB.SysContab.Grupos_InventarioDB

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            subgrupo = ""
    '            cbSubGrupo.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbSubGrupo.Text = "" Then
    '        subgrupo = ""
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If subgrupo.Length = 1 Then
    '            subgrupo = ""
    '        End If

    '        If subgrupo.Length > 1 Then
    '            subgrupo = Mid(subgrupo, 1, subgrupo.Length - 1)
    '        End If

    '        If cbSubGrupo.Text = "" Then
    '            subgrupo = ""
    '            Exit Sub

    '        End If

    '    Else
    '        subgrupo = subgrupo & e.KeyChar

    '    End If

    '    If g.GetListBuscarCombo(subgrupo, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
    '        '
    '    Else
    '        cbSubGrupo.SelectedValue = g.GetListBuscarCombo(subgrupo, "S").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '        cbSubGrupo.SelectionStart = subgrupo.Length
    '        cbSubGrupo.Select(subgrupo.Length, cbSubGrupo.Text.Length)
    '    End If
    'End Sub

    'Private Sub cbSubGrupo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSubGrupo.Leave
    '    Dim g As New VB.SysContab.Grupos_InventarioDB

    '    If Trim(cbSubGrupo.Text) = "" Then
    '        subgrupo = ""
    '        Exit Sub
    '    End If

    '    If g.GetListBuscarCombo(cbSubGrupo.Text, "S").Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
    '        MsgBox("SubGrupo no Existe", MsgBoxStyle.Information)
    '        subgrupo = ""
    '        cbSubGrupo.Focus()
    '        Exit Sub

    '    End If

    '    'cbSubGrupo.SelectedValue = g.GetListBuscarCombo(cbSubGrupo.Text, "P").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '    Cod_SubGrupo = g.GetListBuscarCombo(cbSubGrupo.Text, "S").Tables("GRUPOS_INVENTARIO").Rows(0).Item("CODIGO_GRUPO")
    '    subgrupo = ""
    'End Sub

    Private Sub cbSubGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSubGrupo.SelectedValueChanged
        Dim g As New VB.SysContab.Grupos_InventarioDB

        If Me.cbSubGrupo.SelectedIndex > 0 Then
            Me.cbS_subgrupo.DataSource = g.S_SubGrupos(Me.cbSubGrupo.SelectedValue.ToString, "S").Tables("GruposCC")
            Me.cbS_subgrupo.ValueMember = "Código"
            Me.cbS_subgrupo.DisplayMember = "Nombre"
        End If

        subgrupo = ""

    End Sub

    Private Sub txtPrecio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.Leave
        If Trim(txtPrecio.Text) <> "" Then
            If Trim(txtNumeroHoras.Text) <> "" Then
                txtPrecioHora.Text = txtPrecio.Text / txtNumeroHoras.Text
            End If

            If Trim(txtMargen.Text) <> "" Then
                txtCosto.Text = txtPrecio.Text - (txtPrecio.Text * txtMargen.Text) / 100
                txtCostoPromedio.Text = txtPrecio.Text - (txtPrecio.Text * txtMargen.Text) / 100
                txtCostoUltimo.Text = txtPrecio.Text - (txtPrecio.Text * txtMargen.Text) / 100
            End If
        End If
    End Sub

    Private Sub txtNumeroHoras_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroHoras.Leave
        If Trim(txtNumeroHoras.Text) <> "" Then
            If Trim(txtPrecio.Text) <> "" Then
                txtPrecioHora.Text = txtPrecio.Text / txtNumeroHoras.Text
            End If
        End If
    End Sub

    Private Sub txtMinimoHoras_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinimoHoras.Leave
        Dim incremento As Double
        If Trim(txtMinimoHoras.Text) <> "" Then
            If Trim(txtIncremento.Text) <> "" And Trim(txtPrecioHora.Text) <> "" Then
                incremento = ((txtIncremento.Text * txtPrecioHora.Text) / 100) * txtMinimoHoras.Text
                txtPrecioMinimo.Text = txtMinimoHoras.Text * txtPrecioHora.Text + incremento
            End If
        End If
    End Sub

    Private Sub txtMargen_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargen.Leave
        If Trim(txtMargen.Text) <> "" Then
            If Trim(txtPrecio.Text) <> "" Then
                txtCosto.Text = txtPrecio.Text - (txtPrecio.Text * txtMargen.Text) / 100
                txtCostoPromedio.Text = txtPrecio.Text - (txtPrecio.Text * txtMargen.Text) / 100
                txtCostoUltimo.Text = txtPrecio.Text - (txtPrecio.Text * txtMargen.Text) / 100

            End If
            If Trim(txtTransporte.Text) <> "" Then
                txtValorTransporte.Text = txtTransporte.Text * txtCosto.Text / 100
            End If

            If Trim(txtMaterial.Text) <> "" Then
                txtValorMaterial.Text = txtMaterial.Text * txtCosto.Text / 100
            End If

            If Trim(txtPersonal.Text) <> "" Then
                txtValorPersonal.Text = txtPersonal.Text * txtCosto.Text / 100
            End If

            If Trim(txtExternos.Text) <> "" Then
                txtValorExternos.Text = txtExternos.Text * txtCosto.Text / 100
            End If
        End If
    End Sub

    Private Sub txtIncremento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIncremento.Leave
        Dim incremento As Double
        If Trim(txtIncremento.Text) <> "" Then
            If Trim(txtPrecioHora.Text) <> "" Then
                incremento = ((txtIncremento.Text * txtPrecioHora.Text) / 100) * txtMinimoHoras.Text
                'incremento = (txtIncremento.Text * txtPrecioHora.Text) / 100
                txtPrecioMinimo.Text = txtMinimoHoras.Text * txtPrecioHora.Text + incremento
                txtValorIncremento.Text = incremento
            End If
        End If
    End Sub

    Private Sub txtTransporte_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransporte.Leave
        If Trim(txtTransporte.Text) <> "" Then
            If Trim(txtCosto.Text) <> "" Then
                txtValorTransporte.Text = txtTransporte.Text * txtCosto.Text / 100
            End If
        End If
    End Sub

    Private Sub txtMaterial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaterial.Leave
        If Trim(txtMaterial.Text) <> "" Then
            If Trim(txtCosto.Text) <> "" Then
                txtValorMaterial.Text = txtMaterial.Text * txtCosto.Text / 100
            End If
        End If
    End Sub

    Private Sub txtPersonal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPersonal.Leave
        If Trim(txtPersonal.Text) <> "" Then
            If Trim(txtCosto.Text) <> "" Then
                txtValorPersonal.Text = txtPersonal.Text * txtCosto.Text / 100
            End If
        End If
    End Sub

    Private Sub txtExternos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExternos.Leave
        If Trim(txtExternos.Text) <> "" Then
            If Trim(txtCosto.Text) <> "" Then
                txtValorExternos.Text = txtExternos.Text * txtCosto.Text / 100
            End If
        End If
    End Sub

    Private Sub frmAgregarServicio_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim s As frmServicios = frmServicios.Instance
        s.cargar()
    End Sub

    Private Sub cmdAcumulados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulados.Click
        Dim f As frmVentasServicios = frmVentasServicios.Instance

        f.PC = PC
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cbLinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLinea.SelectedIndexChanged

    End Sub

    Private Sub ChkExento_CheckedChanged(sender As Object, e As EventArgs) Handles ChkExento.CheckedChanged
        BuscarImpuesto()
    End Sub

    Sub BuscarImpuesto()
        If txtCabys.Text.Length = 0 Then
            If Not ChkExento.Checked Then
                txtImpuesto.EditValue = VB.SysContab.ConfiguracionDB.GetConfigDetails().IVA
            Else
                txtImpuesto.EditValue = 0.00
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        With New frmCatalogoCABYS
            .Main(_DT_CABYS)

            If .ok Then
                txtCabys.Text = .Codigo
                txtImpuesto.EditValue = .Impuesto
            End If
        End With
    End Sub
End Class