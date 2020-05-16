Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmProyectAdd

    Public IdProyecto As Integer = 0

    Dim obj As New Proyectos
    Dim db As New db_Proyectos

    Private Sub frmProyectAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub frmProyectAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        CargarCombos()
        '
        Cargar()
    End Sub

    Sub Cargar()
        If IdProyecto <> 0 Then
            obj = db_Proyectos.Detalles(IdProyecto)

            If Not obj Is Nothing Then
                Numero.Text = obj.Numero
                txtCodigo.Text = obj.Codigo
                cbServicio.EditValue = obj.CodigoServicio
                Nombre.Text = obj.Nombre
                cbCliente.EditValue = obj.IdCliente
                txtANombre.Text = obj.ANombre
                cbBodega.EditValue = obj.Bodega
                cbCentroCosto.EditValue = obj.IdCentro
                Fecha.DateTime = obj.Fecha
                Inicio.DateTime = obj.Fecha_Inicio
                Fin.DateTime = obj.Fecha_Fin
                Duracion.Text = obj.Duracion
                cbCatalogo.EditValue = obj.Cuenta
                cbCatalogoCosto.EditValue = obj.CuentaCosto
                cbCatalogoIngresos.EditValue = obj.CuentaIngreso
                v.EditValue = obj.Linea
                cbGrupo.EditValue = obj.Grupo
                mDescripcion.Text = obj.Descripcion
                txtPrecio.EditValue = obj.Precio
            End If

            txtCodigo.Properties.ReadOnly = True
        Else
            Fecha.DateTime = Now.Date
            Inicio.DateTime = Now.Date
            Fin.DateTime = Now.Date
            Numero.Text = db_Proyectos.GetNumero()
        End If
    End Sub

    Sub CargarCombos()

        SearchLookUp(cbServicio, ObtieneDatos("SP_ArticulosGetAll", "S", EmpresaActual), "Nombre", "Codigo", 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)
        SearchLookUp(cbCliente, ObtieneDatos("SP_GetClientes", EmpresaActual, 1), "Nombre", "Codigo", 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)
        SearchLookUp(cbCatalogo, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)
        SearchLookUp(cbCatalogoCosto, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)
        SearchLookUp(cbCatalogoIngresos, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)

        LookUp(cbBodega, ObtieneDatos("JAR_GetBodegasList", EmpresaActual), "UBICACION", "CODIGO", "[Seleccione Bodega]", 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)
        GetCentrosCostosList(cbCentroCosto, 1)

        LookUp(v, VB.SysContab.Grupos_InventarioDB.Lineas("P").Tables("GruposCC"), "Nombre", "Código", "[Seleccione Linea]", 0)
        v.ItemIndex = 0
        Grupo()
    End Sub

    Sub Grupo()
        Try
            LookUp(cbGrupo, VB.SysContab.Grupos_InventarioDB.Grupos(v.EditValue, "P").Tables("GruposCC"), "Nombre", "Código", "[Seleccione Grupo]", 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bGuardar.ItemClick
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If Guardar() Then
            CargarCombos()
            Cargar()
            If frmProyectos.Created Then frmProyectos.Cargar()
            Nombre.Focus()
            Nombre.SelectAll()
        End If
    End Sub

    Function Guardar() As Boolean

        obj.IdProyecto = IdProyecto
        obj.Numero = Numero.Text
        obj.Codigo = txtCodigo.Text
        obj.CodigoServicio = IIf(cbServicio.EditValue Is Nothing, "", cbServicio.EditValue)
        obj.Nombre = Nombre.Text
        obj.IdCliente = cbCliente.EditValue
        obj.ANombre = txtANombre.Text
        obj.Bodega = cbBodega.EditValue
        obj.IdCentro = cbCentroCosto.EditValue
        obj.Fecha = Fecha.DateTime.Date
        obj.Fecha_Inicio = Inicio.DateTime.Date
        obj.Fecha_Fin = Fin.DateTime.Date
        obj.Duracion = Duracion.Text
        obj.Cuenta = cbCatalogo.EditValue
        obj.CuentaCosto = cbCatalogoCosto.EditValue
        obj.CuentaIngreso = cbCatalogoIngresos.EditValue
        obj.Linea = v.EditValue
        obj.Grupo = cbGrupo.EditValue
        obj.Descripcion = mDescripcion.Text
        obj.Estado = "I"
        obj.Precio = txtPrecio.EditValue

        If IdProyecto = 0 Then

            If Not (VB.SysContab.ArticulosDB.GetDetails(Me.txtCodigo.Text, "P").Codigo Is Nothing) Then
                XtraMsg("Ese codigo ya existe", MessageBoxIcon.Error)
                txtCodigo.Focus()
                txtCodigo.SelectAll()
                Return False
            End If

            IdProyecto = db.Insertar(obj)

            Return True
        Else
            db.Actualizar(obj)

            Return True
        End If
    End Function

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bGuardarSalir.ItemClick
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If Guardar() Then
            If frmProyectos.Created Then frmProyectos.Cargar()
            Close()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Close()
    End Sub


    Private Sub cbLinea_EditValueChanged(sender As Object, e As EventArgs) Handles v.EditValueChanged
        Grupo()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If IdProyecto = 0 Then Exit Sub
        '
        db_Proyectos.Imprimir(IdProyecto)
    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        txtANombre.Text = sender.Text
    End Sub

    Private Sub cbServicio_EditValueChanged(sender As Object, e As EventArgs) Handles cbServicio.EditValueChanged
        Nombre.Text = sender.Text
    End Sub
End Class