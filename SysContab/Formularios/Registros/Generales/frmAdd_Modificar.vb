Imports ClasesBLL
Imports DevExpress.XtraEditors

Public Class frmAdd_Modificar

    'Dim dt As DataTable
    'Dim da As SqlDataAdapter
    'Dim cb As SqlCommandBuilder
    Public Codigo As Integer = 0
    'Dim Comprobantes As New VB.SysContab.ComprobanteDB()

    Dim obj As New CatalogoAmortizacion
    Dim db As New db_CatalogoAmortizacion

    Dim obj_Plantilla As New AmortizacionesPlantilla
    Dim db_Plantilla As New db_AmortizacionesPlantilla

    Private Sub frmAdd_Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        CargarCombos()
        Cargar()

        If Codigo > 0 Then
            obj = db_CatalogoAmortizacion.Detalles(Codigo)

            txtcodigo.Text = obj.Codigo
            txtNombre.Text = obj.Nombre
            cmbtipocomprobante.EditValue = obj.TipoCompr
        Else
            txtcodigo.Text = db_CatalogoAmortizacion.GetCodigo()
        End If

        'If Nuevo = "SI" Then   'Guardar Nuevo
        '    Me.lblcodigo.Text = AmortizacionesDB.GetAmorotizacionId()
        'Else    'Actualizar
        '    MostrarDatos()
        'End If
    End Sub

    Sub Cargar()

        iGrid.DataSource = db_AmortizacionesPlantilla.Listar(Codigo)
        FormatoGrid(iVista, 2, 0, False, True, False)

        'If Nuevo = "SI" Then
        '    da = New SqlDataAdapter("Select * From CatalogoAmortizacion WHERE Empresa = " & EmpresaActual & " Order By Codigo", Rutinas.AbrirConexion)
        '    cb = New SqlCommandBuilder(da)
        '    dt = New DataTable
        '    da.Fill(dt)
        'Else
        '    da = New SqlDataAdapter("Select * From CatalogoAmortizacion Where Codigo = '" & Codigo & "' AND Empresa = " & EmpresaActual, Rutinas.AbrirConexion())
        '    cb = New SqlCommandBuilder(da)
        '    dt = New DataTable
        '    da.Fill(dt)
        'End If

        'Me.iVista.DataSource = ObtieneDatos("SELECT ap.Cuenta, ap.Tipo, ap.CentroCosto FROM AmortizacionesPlantilla ap WHERE ap.Codigo = " & Codigo & " AND ap.Empresa = " & EmpresaActual).DefaultView
        'FormatoGrid(Me.vDatos)
    End Sub

    Sub CargarCombos()

        RepositoryGridLookup(cbCatalogo, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)


        'Me.cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual).DefaultView
        'Me.cbCatalogo.ValueMember = "Cuenta"
        'Me.cbCatalogo.DisplayMember = "Display"
        'cbCatalogo.PopulateViewColumns()
        ''Me.vCatalogo.PopulateColumns()
        'FormatoGrid(Me.vCatalogo)

        'Me.vCatalogo.Columns("Display").Visible = False
        'Me.vCatalogo.Columns("Cuenta").VisibleIndex = 0
        'Me.vCatalogo.Columns("Nombre").VisibleIndex = 1
        'Me.vCatalogo.Columns("NombreCompleto").VisibleIndex = 2

        'Me.vCatalogo.BestFitColumns()

        Me.cbDC.DataSource = ObtieneDatos("SELECT 1 Valor, 'Débito' DC UNION ALL SELECT 2 Valor, 'Crédito' DC")
        Me.cbDC.DisplayMember = "DC"
        Me.cbDC.ValueMember = "Valor"
        Me.cbDC.PopulateColumns()
        cbDC.Columns(0).Visible = False


        'Me.cbCuenta1.Properties.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        'Me.cbCuenta1.Properties.DisplayMember = "Display"
        'Me.cbCuenta1.Properties.ValueMember = "Cuenta"
        'Me.cbCuenta1.Properties.PopulateColumns()
        'Me.cbCuenta1.Properties.Columns("Display").Visible = False
        'Me.cbCuenta1.ItemIndex = 0

        'Me.cbCuenta2.Properties.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        'Me.cbCuenta2.Properties.DisplayMember = "Display"
        'Me.cbCuenta2.Properties.ValueMember = "Cuenta"
        'Me.cbCuenta2.Properties.PopulateColumns()
        'Me.cbCuenta2.Properties.Columns("Display").Visible = False
        'Me.cbCuenta2.ItemIndex = 0

        GetTipoComprobantesList(cmbtipocomprobante)
        cmbtipocomprobante.ItemIndex = 0

        'Me.cbTipo.Properties.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
        'Me.cbTipo.Properties.ValueMember = "TipComp_Id"
        'Me.cbTipo.Properties.DisplayMember = "TipComp_Nombre"
        'Me.cbTipo.Properties.PopulateColumns()

        'For i As Integer = 0 To Me.cbTipo.Properties.Columns.Count - 1
        '    Me.cbTipo.Properties.Columns(i).Visible = False
        'Next

        'Me.cbTipo.Properties.Columns(2).Visible = True
        'Me.cbTipo.ItemIndex = 0
    End Sub

    'Private Sub Limpiar()
    '    Me.lblcodigo.Text = String.Empty
    '    Me.txtNombre.Text = String.Empty
    '    Me.cbTipo.ItemIndex = 0
    '    Me.ErrorProvider1.SetError(Me.txtNombre, Nothing)
    '    Me.txtNombre.Focus()
    '    Me.txtNombre.SelectAll()
    'End Sub
    'Private Sub MostrarDatos()        
    '    Me.lblcodigo.Text = dt.Rows(0).Item("Codigo").ToString
    '    Me.txtNombre.Text = dt.Rows(0).Item("Nombre").ToString
    '    Me.cbTipo.EditValue = dt.Rows(0).Item("TipoCompr")
    '    'Me.cbCuenta1.EditValue = dt.Rows(0).Item("Debito").ToString
    '    'Me.cbCuenta2.EditValue = dt.Rows(0).Item("Credito").ToString
    'End Sub
    'Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If Me.txtNombre.Text.Trim.Length = 0 Then
    '        e.Cancel = True
    '        Me.ErrorProvider1.SetError(Me.txtNombre, "Introduzca el Nombre de la Amortización")
    '    Else
    '        Me.ErrorProvider1.SetError(Me.txtNombre, Nothing)
    '    End If
    'End Sub

    'Private Sub cbTipo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipo.Validating
    '    If Me.cbTipo.EditValue Is Nothing Or Me.cbTipo.EditValue = 0 Then
    '        e.Cancel = True
    '        Me.ErrorProvider1.SetError(Me.cbTipo, "Seleccione el Tipo de Comprobante")
    '    Else
    '        Me.ErrorProvider1.SetError(Me.cbTipo, Nothing)
    '    End If
    'End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        obj.Codigo = IIf(Codigo = 0, db_CatalogoAmortizacion.GetCodigo(), txtcodigo.Text)
        obj.Nombre = txtNombre.Text
        obj.Debito = ""
        obj.Credito = ""
        obj.TipoCompr = cmbtipocomprobante.EditValue


        If Codigo = 0 Then
            db.Insertar(obj)
        Else
            db.Actualizar(obj)
        End If
        '
        'Borrar Plantilla actual
        If Codigo > 0 Then
            obj_Plantilla.Codigo = txtcodigo.EditValue
            db_Plantilla.Borrar(obj_Plantilla)
        End If

        '
        'Guardar Plantilla
        obj_Plantilla.Codigo = obj.Codigo
        For i As Integer = 0 To iVista.DataRowCount - 1
            obj_Plantilla.Cuenta = iVista.GetRowCellValue(i, "Cuenta")
            obj_Plantilla.Tipo = iVista.GetRowCellValue(i, "Tipo")
            obj_Plantilla.CentroCosto = 0

            db_Plantilla.Insertar(obj_Plantilla)
        Next

        If FrmMtnoAmortizacion.Created Then FrmMtnoAmortizacion.Cargar()
        Close()


        'If Me.ValidateChildren Then
        '    Dim dr As DataRow

        '    Select Case Nuevo
        '        Case "SI"
        '            dr = dt.NewRow

        '            dr("Codigo") = CInt(Me.lblcodigo.Text)
        '            dr("Nombre") = Me.txtNombre.Text.Trim
        '            dr("Empresa") = EmpresaActual
        '            dr("TipoCompr") = Me.cbTipo.EditValue

        '            'dr("Debito") = Me.cbCuenta1.EditValue
        '            'dr("Credito") = Me.cbCuenta2.EditValue

        '            dt.Rows.Add(dr)
        '        Case "NO"
        '            dr = dt.Rows(0)

        '            dr("Codigo") = CInt(Me.lblcodigo.Text)
        '            dr("Nombre") = Me.txtNombre.Text.Trim
        '            dr("TipoCompr") = Me.cbTipo.EditValue

        '            'dr("Debito") = Me.cbCuenta1.EditValue
        '            'dr("Credito") = Me.cbCuenta2.EditValue
        '    End Select
        '    Try
        '        'Guardar los datos
        '        da.Update(dt)
        '        dt.AcceptChanges()

        '        GuardaDatos("DELETE FROM AmortizacionesPlantilla WHERE Codigo = " & CInt(Me.lblcodigo.Text) & " AND Empresa = " & EmpresaActual)
        '        GuardarPlantilla()

        '        My.Forms.FrmMtnoAmortizacion.Cargar()
        '        Me.Close()
        '    Catch ex As Exception
        '        XtraMessageBox.Show("ERROR : " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If
    End Sub

    'Sub GuardarPlantilla()
    '    Dim Datos As New ArrayList
    '    Dim Variables As New ArrayList

    '    Variables.Add("Empresa")
    '    Variables.Add("Codigo")
    '    Variables.Add("Cuenta")
    '    Variables.Add("Tipo")
    '    Variables.Add("CentroCosto")

    '    Datos.Add(EmpresaActual)
    '    Datos.Add(CInt(Me.lblcodigo.Text))
    '    Datos.Add("")
    '    Datos.Add(0)
    '    Datos.Add(0)

    '    For i As Integer = 0 To Me.iVista.DataRowCount - 1
    '        Datos.Item(2) = Me.iVista.GetRowCellValue(i, "Cuenta")
    '        Datos.Item(3) = Me.iVista.GetRowCellValue(i, "Tipo")

    '        ProcedureSave(Datos, Variables, "sp_GuardarAmortizaPlantilla")
    '    Next
    'End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

   
End Class