Public Class frmPropiedades

    Dim obj As New PNR_Propiedades
    Dim db As New db_PNR_Propiedades

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar()
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year
        '
        iGrid.ForceInitialize()
        iVista.PopulateColumns()
        SimpleFormatGrid(iVista, False, DevExpress.Utils.HorzAlignment.Center, 1, 2, True, 0)

        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        iVista.OptionsDetail.SmartDetailExpand = True
    End Sub

    Sub Cargar()
        Dim DS As New DataSet

        Dim Maestro As DataTable = db_PNR_Propiedades.Listar(0, 0, cbPeriodo.EditValue)
        Maestro.TableName = "Maestro"

        Dim Detalle As DataTable = db_PNR_Propiedades_Detalle.Listar(0)
        Detalle.TableName = "Detalle"

        DS.Tables.Add(Maestro)
        DS.Tables.Add(Detalle)
        DS.Relations.Add("Propiedades Detalle", Maestro.Columns("IdPropiedad"), Detalle.Columns("IdPropiedad"), False)

        iGrid.DataSource = DS.Tables("Maestro")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        With frmPropiedadesAdd
            .IdPropiedad = 0
            .Text = "Agregar Propiedad por Cliente"
            .ShowDialog()            
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        With frmPropiedadesAdd
            .cbCliente.Properties.ReadOnly = IIf(iVista.GetFocusedRowCellValue("IdPlanNegocio") = 0, True, False)
            .IdPropiedad = iVista.GetFocusedRowCellValue("IdPropiedad")
            .Text = "Editar Propiedad por Cliente"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.IdPropiedad = iVista.GetFocusedRowCellValue("IdPropiedad")
        obj.Valor = 0

        Dim Valor As String = db.Borrar(obj)
        If IsNumeric(Valor) Then Cargar() Else XtraMsg(Valor, MessageBoxIcon.Error)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub frmPropiedades_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub
End Class