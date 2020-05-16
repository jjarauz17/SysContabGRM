Public Class frmConfigurarCorreo

    Dim obj As New CorreoConfig
    Dim db As New db_CorreoConfig

    Dim objDetalle As New CorreoCopia
    Dim dbDetalle As New db_CorreoCopia

    Dim Nuevo As Boolean = False

    Private Sub bGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bGuardar.ItemClick
        'If TabbedControlGroup1.SelectedTabPageIndex = 0 Or TabbedControlGroup1.SelectedTabPageIndex = 1 Then
        '    If Not DxValidationProvider1.Validate Then Exit Sub
        'End If
        '
        Guardar()
        Cargar()
    End Sub

    Sub Guardar()

        'Guardar 1ra Pestaña
        If TabbedControlGroup1.SelectedTabPageIndex = 0 Then
            Nuevo = False
            obj = db_CorreoConfig.Detalles(1, IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue))
            If obj.Correo Is Nothing Then Nuevo = True

            obj.Tipo = 1
            obj.Empresa = EmpresaActual
            obj.Correo = EnvioEC.Text
            obj.Clave = ClaveEC.Text
            obj.Smtp = smtpEC.Text
            obj.SSL = IIf(chkSslEC.Checked, 1, 0)
            obj.Puerto = PuertoEC.EditValue
            obj.IdSucursal = IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue)
            obj.Perfil = ""
            obj.Copia = ""
            obj.Asunto = ""
            obj.ANombre = ""
            '
            If Nuevo Then   'Nuevo
                obj.IdCorreo = 0
                objDetalle.IdCorreo = db.Insertar(obj)
            Else
                objDetalle.IdCorreo = obj.IdCorreo
                db.Actualizar(obj)
            End If

            'Guardar Detalle, pero primero Borrar        
            dbDetalle.Borrar(objDetalle)
            objDetalle.Empresa = EmpresaActual
            '
            For i As Integer = 0 To iVistaEC.DataRowCount - 1
                If IsNull(iVistaEC.GetRowCellValue(i, "Correo"), "") <> "" Then
                    objDetalle.Correo = IsNull(iVistaEC.GetRowCellValue(i, "Correo"), "")
                    dbDetalle.Insertar(objDetalle)
                End If
            Next
        End If

        'Guardar 2da Pestaña
        If TabbedControlGroup1.SelectedTabPageIndex = 1 Then
            Nuevo = False
            obj = db_CorreoConfig.Detalles(2, "")
            If obj.Correo Is Nothing Then Nuevo = True

            obj.Tipo = 2
            obj.Empresa = EmpresaActual
            obj.Correo = EnvioFV.Text
            obj.Clave = ClaveFV.Text
            obj.Smtp = smtpFV.Text
            obj.SSL = IIf(chkSslFV.Checked, 1, 0)
            obj.Puerto = PuertoFV.EditValue
            obj.IdSucursal = ""
            obj.Perfil = ""
            obj.Copia = ""
            obj.Asunto = ""
            obj.ANombre = ""

            If Nuevo Then   'Nuevo
                obj.IdCorreo = 0
                objDetalle.IdCorreo = db.Insertar(obj)
            Else
                objDetalle.IdCorreo = obj.IdCorreo
                db.Actualizar(obj)
            End If
            '
            'Guardar Detalle, pero primero Borrar        
            dbDetalle.Borrar(objDetalle)
            objDetalle.Empresa = EmpresaActual
            '
            For i As Integer = 0 To iVistaFV.DataRowCount - 1
                If IsNull(iVistaFV.GetRowCellValue(i, "Correo"), "") <> "" Then
                    objDetalle.Correo = IsNull(iVistaFV.GetRowCellValue(i, "Correo"), "")
                    dbDetalle.Insertar(objDetalle)
                End If
            Next

        End If

        'Guardar 3ra Pestaña
        If TabbedControlGroup1.SelectedTabPageIndex = 2 Then
            Nuevo = False
            obj = db_CorreoConfig.Detalles(3, "")
            If obj.Correo Is Nothing Then Nuevo = True

            obj.Tipo = 3
            obj.Empresa = EmpresaActual
            obj.Correo = tCorreo.Text
            obj.Clave = ""
            obj.Smtp = ""
            obj.SSL = 0
            obj.Puerto = 0
            obj.IdSucursal = ""
            obj.Perfil = cbPerfiles.EditValue
            obj.Copia = mCC.Text
            obj.Asunto = tAsunto.Text
            obj.ANombre = ""

            If Nuevo Then   'Nuevo
                obj.IdCorreo = 0
                objDetalle.IdCorreo = db.Insertar(obj)
            Else
                objDetalle.IdCorreo = obj.IdCorreo
                db.Actualizar(obj)
            End If
        End If

        'Guardar 4ta Pestaña
        If TabbedControlGroup1.SelectedTabPageIndex = 3 Then

            Nuevo = False
            obj = db_CorreoConfig.Detalles(4, "")
            If obj.Correo Is Nothing Then Nuevo = True

            obj.Tipo = 4
            obj.Empresa = EmpresaActual
            obj.Correo = tCorreo2.Text
            obj.Clave = ""
            obj.Smtp = ""
            obj.SSL = 0
            obj.Puerto = 0
            obj.IdSucursal = ""
            obj.Perfil = cbPerfiles2.EditValue
            obj.Copia = mCC2.Text
            obj.Asunto = tAsunto2.Text
            obj.ANombre = ""

            If Nuevo Then   'Nuevo
                obj.IdCorreo = 0
                objDetalle.IdCorreo = db.Insertar(obj)
            Else
                objDetalle.IdCorreo = obj.IdCorreo
                db.Actualizar(obj)
            End If

        End If

        'Guardar 5ta Pestaña
        If TabbedControlGroup1.SelectedTabPageIndex = 4 Then

            Nuevo = False
            obj = db_CorreoConfig.Detalles(5, "")
            If obj.Correo Is Nothing Then Nuevo = True

            obj.Tipo = 5
            obj.Empresa = EmpresaActual
            obj.Correo = tCorreoEnviar.Text
            obj.Clave = ""
            obj.Smtp = ""
            obj.SSL = 0
            obj.Puerto = 0
            obj.IdSucursal = ""
            obj.Perfil = cbPerfil3.EditValue
            obj.Copia = mCC3.Text
            obj.Asunto = tAsuntoVence.Text
            obj.ANombre = tNombre.Text

            If Nuevo Then   'Nuevo
                obj.IdCorreo = 0
                objDetalle.IdCorreo = db.Insertar(obj)
            Else
                objDetalle.IdCorreo = obj.IdCorreo
                db.Actualizar(obj)
            End If

        End If


        XtraMsg("Configuracion Guardada con Exito!")


        'Dim RptSub As New Rpt_FacturaDetallesFormaPagoTicket
        'SubRptSub.DataSource = dt_FormaPago

        'Dim RptSub As New Rpt_FacturaDetallesFormaPagoTicket
        'SubRptSub.DataSource = dt_FormaPago

        'Dim f As New mdi_reporte
        'f.PrintControl1.PrintingSystem = rpt.PrintingSystem
        'rpt.SRDetallePago.ReportSource = RptSub
        'rpt.CreateDocument()
    End Sub

    Private Sub bGuardarSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bGuardarSalir.ItemClick
        'If TabbedControlGroup1.SelectedTabPageIndex = 0 Or TabbedControlGroup1.SelectedTabPageIndex = 1 Then
        '    If Not DxValidationProvider1.Validate Then Exit Sub
        'End If
        '
        Guardar()
        Close()
    End Sub

    Private Sub bSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSalir.ItemClick
        Close()
    End Sub

    Private Sub frmConfigurarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        GetSucursales(cbSucursal)
        cbSucursal.ItemIndex = 0

        LookUp(cbPerfiles, ObtieneDatos("JAR_PerfilesMailSQL"), "Nombre", "Nombre", "[Seleccione Perfil]")
        LookUp(cbPerfiles2, ObtieneDatos("JAR_PerfilesMailSQL"), "Nombre", "Nombre", "[Seleccione Perfil]")
        LookUp(cbPerfil3, ObtieneDatos("JAR_PerfilesMailSQL"), "Nombre", "Nombre", "[Seleccione Perfil]")
        If cbSucursal.EditValue Is Nothing Then Cargar()                
    End Sub

    Sub Cargar()
        '1era Pestaña.
        obj = db_CorreoConfig.Detalles(1, IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue))

        If Not obj.Correo Is Nothing Then            
            EnvioEC.Text = obj.Correo
            ClaveEC.Text = obj.Clave
            smtpEC.Text = obj.Smtp
            chkSslEC.Checked = IIf(obj.SSL = 1, True, False)
            PuertoEC.Text = obj.Puerto
        Else
            obj.IdCorreo = 0

            '
            EnvioEC.Text = ""
            ClaveEC.Text = ""
            smtpEC.Text = ""
            chkSslEC.Checked = False
            PuertoEC.Text = 25
        End If

        iGridEC.DataSource = db_CorreoCopia.Listar(obj.IdCorreo)

        '2da Pestaña
        obj = db_CorreoConfig.Detalles(2, "")

        If Not obj.Correo Is Nothing Then 
            EnvioFV.Text = obj.Correo
            ClaveFV.Text = obj.Clave
            smtpFV.Text = obj.Smtp
            chkSslFV.Checked = IIf(obj.SSL = 1, True, False)
            PuertoFV.Text = obj.Puerto
        Else
            obj.IdCorreo = 0
        End If

        iGridFV.DataSource = db_CorreoCopia.Listar(obj.IdCorreo)

        '3ra Pestaña
        obj = db_CorreoConfig.Detalles(3, "")

        If Not obj.Correo Is Nothing Then
            cbPerfiles.EditValue = obj.Perfil
            tCorreo.Text = obj.Correo
            mCC.Text = obj.Copia
            tAsunto.Text = obj.Asunto           
        Else
            obj.IdCorreo = 0
        End If

        '4ta Pestaña
        obj = db_CorreoConfig.Detalles(4, "")

        If Not obj.Correo Is Nothing Then
            cbPerfiles2.EditValue = obj.Perfil
            tCorreo2.Text = obj.Correo
            mCC2.Text = obj.Copia
            tAsunto2.Text = obj.Asunto
        Else
            obj.IdCorreo = 0
        End If

        'tta Pestaña
        obj = db_CorreoConfig.Detalles(5, "")

        If Not obj.Correo Is Nothing Then
            cbPerfil3.EditValue = obj.Perfil
            tCorreoEnviar.Text = obj.Correo
            mCC3.Text = obj.Copia
            tNombre.Text = obj.ANombre
            tAsuntoVence.Text = obj.Asunto
        Else
            obj.IdCorreo = 0
        End If

    End Sub

    Private Sub iVistaEC_KeyDown(sender As Object, e As KeyEventArgs) Handles iVistaEC.KeyDown
        If iVistaEC.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            iVistaEC.DeleteSelectedRows()
            iVistaEC.RefreshData()
        End If      
    End Sub

    Private Sub iVistaFV_KeyDown(sender As Object, e As KeyEventArgs) Handles iVistaFV.KeyDown
        If iVistaFV.FocusedRowHandle < 0 Then Exit Sub
        '
        If e.KeyCode = Keys.Delete Then
            iVistaFV.DeleteSelectedRows()
            iVistaFV.RefreshData()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PruebaEnvio1()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        PruebaEnvio2()
    End Sub

    Private Sub PruebaEnvio1()
        'If Not DxValidationProvider1.Validate Then Exit Sub

        Dim db As New db_EnviarCorreo

        db.Test("Prueba de Envio!", EnvioEC.Text, ClaveEC.Text, smtpEC.Text, chkSslEC.Checked, PuertoEC.EditValue)
    End Sub

    Private Sub PruebaEnvio2()
        If Not DxValidationProvider1.Validate Then Exit Sub

        Dim db As New db_EnviarCorreo

        db.Test("Prueba de Envio!", EnvioFV.Text, ClaveFV.Text, smtpFV.Text, chkSslFV.Checked, PuertoFV.EditValue)
    End Sub

    Private Sub PruebaEnvio3()
        If cbPerfiles.EditValue Is Nothing Then
            XtraMsg("No se ha seleccionado perfil de envío de correo", MessageBoxIcon.Warning)
            cbPerfiles.Focus()
            Exit Sub
        End If

        If tCorreo.Text.Trim.Length = 0 Then
            XtraMsg("Escriba correo de envío", MessageBoxIcon.Warning)
            tCorreo.Focus()
            Exit Sub
        End If

        Dim db As New db_EnviarCorreo


        db.Test_Send_db_mail(cbPerfiles.EditValue, tCorreo.Text, mCC.Text, tAsunto.Text)
    End Sub

    Private Sub PruebaEnvio4()
        If cbPerfiles2.EditValue Is Nothing Then
            XtraMsg("No se ha seleccionado perfil de envío de correo", MessageBoxIcon.Warning)
            cbPerfiles2.Focus()
            Exit Sub
        End If

        If tCorreo2.Text.Trim.Length = 0 Then
            XtraMsg("Escriba correo de envío", MessageBoxIcon.Warning)
            tCorreo2.Focus()
            Exit Sub
        End If

        Dim db As New db_EnviarCorreo

        db.Test_Send_db_mail(cbPerfiles2.EditValue, tCorreo2.Text, mCC2.Text, tAsunto2.Text)
    End Sub

    Private Sub PruebaEnvio5()
        If cbPerfil3.EditValue Is Nothing Then
            XtraMsg("No se ha seleccionado perfil de envío de correo", MessageBoxIcon.Warning)
            cbPerfil3.Focus()
            Exit Sub
        End If

        If mCC3.Text.Trim.Length = 0 Then
            XtraMsg("Escriba correo de envío", MessageBoxIcon.Warning)
            mCC3.Focus()
            Exit Sub
        End If

        Dim db As New db_EnviarCorreo

        db.Test_Send_db_mail(cbPerfil3.EditValue, mCC3.Text, "", tAsuntoVence.Text)
    End Sub

    Private Sub bPrueba_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bPrueba.ItemClick
        If TabbedControlGroup1.SelectedTabPageIndex = 0 Then PruebaEnvio1()
        If TabbedControlGroup1.SelectedTabPageIndex = 1 Then PruebaEnvio2()
        If TabbedControlGroup1.SelectedTabPageIndex = 2 Then PruebaEnvio3()
        If TabbedControlGroup1.SelectedTabPageIndex = 3 Then PruebaEnvio4()
        If TabbedControlGroup1.SelectedTabPageIndex = 4 Then PruebaEnvio5()
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged
        Cargar()
    End Sub

    Private Sub bPruebaFact_Click(sender As Object, e As EventArgs) Handles bPruebaFact.Click
        PruebaEnvio3()
    End Sub

    Private Sub bPruebaDev_Click(sender As Object, e As EventArgs) Handles bPruebaDev.Click
        PruebaEnvio4()
    End Sub
End Class