Imports ClasesBLL
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCacularAmortizacion

    Dim cnn As SqlConnection    'Variable de conexion 
    Dim ID_amortiza As Integer
    Dim M_amortizado As Decimal
    'Dim Tabla As DataTable
    Dim TCambio As Double = 1

    Dim DT_Amortiza As New DataTable("Amortizaciones")

    Dim obj As New Amortizaciones
    Dim obj_Detalle As New AmortizacionesDetalle

    Dim db As New db_Amortizaciones
    Dim db_Detalle As New db_AmortizacionesDetalle

    Private Sub frmCacularAmortizacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ''Cargar Datos en Combo
        'Me.cbNombre.Properties.DataSource = ObtieneDatos("SELECT 0 Codigo,'--- Seleccione Amortización ---' Nombre UNION SELECT Codigo,Nombre From CatalogoAmortizacion WHERE Empresa = " & EmpresaActual).DefaultView
        'Me.cbNombre.EditValue = 0
    End Sub

    Private Sub frmCacularAmortizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(frmCacularAmortizacionConvertedLayout)
        ''
        Me.Fecha_inicio.DateTime = Now.Date
        Me.Fecha_limite.DateTime = Now.Date

        Me.Fecha_limite.DateTime = Me.Fecha_inicio.DateTime.AddMonths(CInt(Me.sPlazo.EditValue - 1))
        'Dim sql_consulta As String = "Select mon_codigo, mon_simbolo + ' - ' + mon_descripcion AS Moneda  From Monedas Where empr_codigo = " & EmpresaActual & ""
        'CARGAR COMBO MONDEDAS DE LA BASE DE DATOS SYSCONTAB
        'Dim da As New SqlDataAdapter(sql_consulta, Rutinas.AbrirConexion)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'Cargar Datos en Combo

        SearchLookUp(cbAmorizaciones, db_CatalogoAmortizacion.Listar(0), "Nombre", "Codigo", 2, 3, 4, 6, 7, 8, 12)

        GetMonedasList(cbMoneda)
        GetTasa()
        '
        CargarTabla()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, False)
    End Sub

    Sub CargarTabla()
        DT_Amortiza = db_Amortizaciones.Tabla(0)
        iGrid.DataSource = DT_Amortiza
    End Sub


    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        'If txtValor.EditValue <= 0 Then
        '    XtraMsg("El Valor a Amortizar debe ser un Valor Mayor que Cero (0)")
        '    txtValor.Focus()
        '    Exit Sub
        'End If

        'If Not Validar() Then
        '    Exit Sub
        'End If


        'If Me.Fecha_limite.DateTime.Date >= Me.Fecha_inicio.DateTime.Date.AddMonths(CInt(Me.sPlazo.EditValue - 1)) Then
        '    If Not cbAmorizaciones.EditValue Is Nothing Then
        '        Return True
        '    Else
        '        XtraMsg("Seleccione el Nombre de la Amortización a Calcular", MessageBoxIcon.Warning)
        '        Return False
        '    End If
        'Else
        '    XtraMsg("Revisar Fecha de Inicio y Fecha Limite de Amortización", MessageBoxIcon.Error)
        '    Return False
        'End If

        If cbAmorizaciones.EditValue Is Nothing Then
            XtraMsg("Seleccione una Amortización")
            cbAmorizaciones.Focus()
            Exit Sub
        End If
        '
        If Fecha_limite.DateTime.Date < Fecha_inicio.DateTime.AddMonths(sPlazo.EditValue - 1).Date Then
            XtraMsg("Revisar Fecha de Inicio y Fecha Limite de Amortización", MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case db_Amortizaciones.Estado(cbAmorizaciones.EditValue)
            Case "NUEVA"
                CrearTabla()
                'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
                'AmortizacionesDB.ImprimirAmortizacion(cbNombre.EditValue)
            Case "CREADA"
                If XtraMsg2("La Tabla de la Amortización " & cbAmorizaciones.Text.ToUpper & " ya se ha Creado, ¿ Desea Modificarla ?") Then
                    CrearTabla()
                    'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
                Else
                    DT_Amortiza = db_Amortizaciones.Tabla(cbAmorizaciones.EditValue)
                    iGrid.DataSource = DT_Amortiza

                    'DetalleCREADA()
                    'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
                End If
            Case "PROCESO"

                XtraMsg2("La Amortización " & cbAmorizaciones.Text.ToUpper & " se encuentra en Proceso, No puede ser modificada.")

                DT_Amortiza = db_Amortizaciones.Tabla(cbAmorizaciones.EditValue)
                iGrid.DataSource = DT_Amortiza

                'If XtraMsg2("La Amortización " & cbAmorizaciones.Text.ToUpper & " ya se ha generado, Ver el Detalle ?") Then
                '    'Dim rpt As New rptDetalle_Amortizacion
                '    'rpt.DataSource = AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
                '    'frmExportarImprimir.Mostrar(rpt)

                '    'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
                '    'My.Forms.frmexportaciongrid.ShowDialog()
                '    'AmortizacionesDB.IMPRIMIR(My.Forms.frmexportaciongrid.Formato, 1)

                '    AmortizacionesDB.ImprimirAmortizacion(cbNombre.EditValue)
                'End If
        End Select

        'If BuscarAmortizacion() Then
        '    DetalleAmortizacion()
        '    'Activar Botones
        '    Me.btnSave.Enabled = True
        'Else
        '    'Deshactivar Botones
        '    Me.btnSave.Enabled = False
        '    Me.btnPrevio.Enabled = False
        '    Me.dgAmortiza.DataSource = Nothing
        '    'Me.ListAmortiza.Items.Clear()
        'End If
    End Sub

    Sub CrearTabla()
        'Dim Inicio As Date = Me.Fecha_inicio.DateTime
        Dim monto_inicial As Decimal = Decimal.Round(CDec(Me.txtValor.Text), 2)
        Dim monto_amortizado As Decimal = CDec(monto_inicial / CInt(Me.sPlazo.EditValue))
        Dim dr As DataRow

        'CrearTabla()
        'Me.iGrid.DataSource = Nothing

        DT_Amortiza.Clear()

        For i As Integer = 0 To CInt(Me.sPlazo.EditValue) - 1
            dr = DT_Amortiza.NewRow()

            dr("Numero") = (i + 1)
            dr("Fecha") = Me.Fecha_inicio.DateTime.Date.AddMonths(i)
            dr("Monto Incial") = Decimal.Round(monto_inicial, 2)
            dr("A Amortizar") = Decimal.Round(monto_amortizado, 2)
            dr("Contabilizado") = False

            DT_Amortiza.Rows.Add(dr)

            'Inicio = Me.Fecha_inicio.DateTime.AddMonths(i + 1)
            monto_inicial = monto_inicial - monto_amortizado
        Next

        iGrid.DataSource = DT_Amortiza

        'Me.iGrid.DataSource = Tabla.DefaultView
        'M_amortizado = Me.iVista.GetRowCellValue(0, "MAmortiza")
    End Sub

    'Sub DetalleCREADA()
    '    Dim dt As DataTable = ObtieneDatos(
    '    "SELECT ad.num_amortizacion NO,ad.Fecha,ad.Monto_Inicial MInicial,ad.Monto_Amortizado MAmortiza" _
    '    + " FROM Amortizaciones a INNER JOIN AmortizacionesDetalle ad" _
    '    + " ON a.Cod_amortizacion = ad.Cod_amortizacion AND a.Empresa = ad.Empresa" _
    '    + " Where a.Nombre = " & Me.cbNombre.EditValue & " AND ad.contabilizar = 0 AND a.Empresa = " & EmpresaActual)

    '    Me.iGrid.DataSource = dt.DefaultView
    '    M_amortizado = Me.iVista.GetRowCellValue(0, "MAmortiza")
    'End Sub

    Sub DetalleAmortizacion()
        '

    End Sub

    'Private Function BuscarAmortizacion() As String

    '    Dim dt As DataTable = ObtieneDatos(
    '    "SELECT DISTINCT contabilizar FROM Amortizaciones a INNER JOIN AmortizacionesDetalle ad" _
    '    + " ON a.Cod_amortizacion = ad.Cod_amortizacion AND a.Empresa = ad.Empresa" _
    '    + " Where a.Nombre = " & Me.cbNombre.EditValue & " AND a.Estado = 1 AND a.Empresa = " & EmpresaActual)

    '    If dt.Rows.Count = 0 Then
    '        Return "NUEVA"  'Crar Nueva
    '    ElseIf dt.Rows.Count = 1 Then
    '        If dt.Rows.Item(0)(0) = False Then  'Mostrar Para Modificar
    '            Return "CREADA"
    '        Else
    '            Return "NUEVA"  'Ya se Contabilizó Todo, Volver a Utilizar
    '        End If
    '    ElseIf dt.Rows.Count = 2 Then   'En Proceso No se Puede Modificar
    '        Return "PROCESO"
    '    End If

    '    'Dim sql As String = "SELECT * FROM Amortizaciones Where Nombre = " & Me.cbNombre.EditValue & " AND Estado = 1 AND Empresa = " & EmpresaActual
    '    'Dim DA As New SqlDataAdapter(sql, Rutinas.AbrirConexion)
    '    'Dim DT As New DataTable
    '    'DA.Fill(DT)

    '    'If dt.Rows.Count = 0 Then Return True
    '    'If dt.Rows.Count > 0 Then Return False

    '    Return Nothing
    'End Function

    'Private Function Validar() As Boolean

    '    If Me.Fecha_limite.DateTime.Date >= Me.Fecha_inicio.DateTime.Date.AddMonths(CInt(Me.sPlazo.EditValue - 1)) Then
    '        If Not cbAmorizaciones.EditValue Is Nothing Then
    '            Return True
    '        Else
    '            XtraMsg("Seleccione el Nombre de la Amortización a Calcular", MessageBoxIcon.Warning)
    '            Return False
    '        End If
    '    Else
    '        XtraMsg("Revisar Fecha de Inicio y Fecha Limite de Amortización", MessageBoxIcon.Error)
    '        Return False
    '    End If
    'End Function



    Sub GetTasa()
        '**** Cargar Tasa de Cambio
        TCambio = CDbl(ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & Me.Fecha_inicio.DateTime.Date & "')").Rows.Item(0)(0))
        txtTasa.EditValue = TCambio
    End Sub

    'Sub CrearTabla()
    '    Tabla = New DataTable("AMORTIZA")

    '    'TABLA VISTA PREVIA
    '    Tabla.Columns.Add("NO", Type.GetType("System.Int32"))
    '    Tabla.Columns.Add("Fecha", Type.GetType("System.DateTime"))
    '    Tabla.Columns.Add("MInicial", Type.GetType("System.Decimal"))
    '    Tabla.Columns.Add("MAmortiza", Type.GetType("System.Decimal"))
    'End Sub


    Private Function Guardar_datos() As Integer

        'Dim CodA As Integer = 0

        'Try
        '    CodA = ObtieneDatos(
        '    "SELECT a.Cod_amortizacion Codigo FROM Amortizaciones a WHERE a.Nombre = " & Me.cbNombre.EditValue & "" _
        '    + " AND a.Estado = 1 AND a.Empresa = " & EmpresaActual).Rows.Item(0)(0)

        '    Dim DEL As New SqlCommand("DELETE FROM Amortizaciones WHERE Cod_amortizacion = " & CodA, cnn)
        '    DEL.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try



        'Dim sql_inser As String = "INSERT INTO Amortizaciones (Cod_amortizacion,Empresa,Fecha_Inicial,Fecha_Limite,Plazo,Nombre,Moneda,Monto_total,Monto_amortizado)" _
        '+ " VALUES (@codigo,@empresa,@f_inicial,@f_limite,@plazo,@nombre,@moneda,@m_total,@m_amortizado)"

        'Dim cmd As New SqlCommand(sql_inser, cnn)
        'Parametros(cmd, 1, 0)

        'cmd.ExecuteNonQuery()

        'Return CodA
    End Function

    'Private Sub Guardar_Detalle(ByVal CodA As Integer)

    '    Dim sSQL As String = "DELETE FROM AmortizacionesDetalle WHERE Cod_amortizacion = " & CodA & "" _
    '    + " AND contabilizar = 0 AND Empresa = " & EmpresaActual

    '    Dim DEL As New SqlCommand(sSQL, cnn)
    '    DEL.ExecuteNonQuery()


    '    Dim sql_inser As String = "INSERT INTO AmortizacionesDetalle (Cod_amortizacion,num_amortizacion,Fecha,Mes,Monto_Inicial,Monto_Amortizado,Empresa)" _
    '    + " VALUES (@Cod_amotizacion,@num,@fecha,@mes,@m_inicial,@m_amortizado,@Empresa)"

    '    For i As Integer = 0 To CInt(Me.sPlazo.EditValue) - 1
    '        Dim cmd As New SqlCommand(sql_inser, cnn)
    '        Parametros(cmd, 2, i + 1)

    '        cmd.ExecuteNonQuery()

    '        cmd = Nothing
    '    Next
    'End Sub

    Private Sub Parametros(ByVal cmd As SqlCommand, ByVal op As Integer, ByVal num As Integer)

        'Select Case op
        '    Case 1  'Parametros para datos de amortizacion
        '        ID_amortiza = AmortizacionesDB.GenerarID("Amortizaciones")   'Generar el Id de la amortizacion

        '        cmd.Parameters.Add("@codigo", SqlDbType.Int)
        '        cmd.Parameters.Add("@empresa", SqlDbType.Int)
        '        cmd.Parameters.Add("@f_inicial", SqlDbType.SmallDateTime)
        '        cmd.Parameters.Add("@f_limite", SqlDbType.SmallDateTime)
        '        cmd.Parameters.Add("@plazo", SqlDbType.Int)
        '        cmd.Parameters.Add("@nombre", SqlDbType.Int)
        '        cmd.Parameters.Add("@moneda", SqlDbType.NVarChar)
        '        cmd.Parameters.Add("@m_total", SqlDbType.Decimal)
        '        cmd.Parameters.Add("@m_amortizado", SqlDbType.Decimal)

        '        cmd.Parameters("@codigo").Value = ID_amortiza
        '        cmd.Parameters("@empresa").Value = EmpresaActual
        '        cmd.Parameters("@f_inicial").Value = Me.Fecha_inicio.DateTime.Date
        '        cmd.Parameters("@f_limite").Value = Me.Fecha_limite.DateTime.Date
        '        cmd.Parameters("@plazo").Value = CInt(Me.sPlazo.EditValue)
        '        cmd.Parameters("@nombre").Value = Me.cbNombre.EditValue
        '        cmd.Parameters("@moneda").Value = cbMoneda.EditValue
        '        cmd.Parameters("@m_total").Value = CDec(Me.txtValor.Text)
        '        cmd.Parameters("@m_amortizado").Value = M_amortizado

        '    Case 2  'Parametros para el detalle de la amortizacion
        '        cmd.Parameters.Add("@Cod_amotizacion", SqlDbType.Int)
        '        cmd.Parameters.Add("@num", SqlDbType.Int)
        '        cmd.Parameters.Add("@fecha", SqlDbType.SmallDateTime)
        '        cmd.Parameters.Add("@mes", SqlDbType.NVarChar)
        '        cmd.Parameters.Add("@m_inicial", SqlDbType.Decimal)
        '        cmd.Parameters.Add("@m_amortizado", SqlDbType.Decimal)
        '        cmd.Parameters.Add("@empresa", SqlDbType.Int)

        '        cmd.Parameters("@Cod_amotizacion").Value = ID_amortiza
        '        cmd.Parameters("@num").Value = num
        '        cmd.Parameters("@fecha").Value = Me.iVista.GetRowCellValue(num - 1, "Fecha") 'CDate(Me.ListAmortiza.Items(num - 1).SubItems(1).Text)
        '        cmd.Parameters("@mes").Value = Format(CDate(Me.iVista.GetRowCellValue(num - 1, "Fecha")), "yyyy") & Format(CDate(Me.iVista.GetRowCellValue(num - 1, "Fecha")), "MM")
        '        cmd.Parameters("@m_inicial").Value = Me.iVista.GetRowCellValue(num - 1, "MInicial") 'CDec(Me.ListAmortiza.Items(num - 1).SubItems(2).Text)
        '        cmd.Parameters("@m_amortizado").Value = Me.iVista.GetRowCellValue(num - 1, "MAmortiza") 'Me.ListAmortiza.Items(num - 1).SubItems(3).Text
        '        cmd.Parameters("@empresa").Value = EmpresaActual
        'End Select

    End Sub

    Private Sub Fecha_inicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Fecha_limite.DateTime = Me.Fecha_inicio.DateTime.AddMonths(Me.sPlazo.EditValue - 1)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.iVista.DataRowCount = 0 Then
            XtraMsg("No Hay Registros en la Tabla de Amortización", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If cbAmorizaciones.EditValue Is Nothing Then
            XtraMsg("Seleccione una Amortización")
            cbAmorizaciones.Focus()
            Exit Sub
        End If
        '
        If Fecha_limite.DateTime.Date < Fecha_inicio.DateTime.AddMonths(sPlazo.EditValue - 1).Date Then
            XtraMsg("Revisar Fecha de Inicio y Fecha Limite de Amortización", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Estado As String = db_Amortizaciones.Estado(cbAmorizaciones.EditValue)

        If Estado = "NUEVA" Or
            Estado = "CREADA" Then

            Dim DT_BUSCAR As DataTable = db_Amortizaciones.BuscarAmoritzacion(cbAmorizaciones.EditValue)

            If DT_BUSCAR.Rows.Count = 0 Then obj.Cod_amortizacion = db_Amortizaciones.GetCodigo()
            If DT_BUSCAR.Rows.Count > 0 Then obj.Cod_amortizacion = DT_BUSCAR.Rows.Item(0)("Codigo")

            'obj.Cod_amortizacion = IIf(DT_BUSCAR.Rows.Count = 0, db_Amortizaciones.GetCodigo(), DT_BUSCAR.Rows.Item(0)("Codigo"))
            obj.Fecha_Inicial = Fecha_inicio.DateTime.Date
            obj.Fecha_Limite = Fecha_limite.DateTime.Date
            obj.Plazo = sPlazo.EditValue
            obj.Nombre = cbAmorizaciones.EditValue
            obj.Moneda = cbMoneda.EditValue
            obj.Monto_total = txtValor.EditValue
            obj.Monto_amortizado = Math.Round(CDbl(txtValor.EditValue / sPlazo.EditValue), 2)
            '
            obj_Detalle.Cod_amortizacion = obj.Cod_amortizacion


            'Si es la Primera Vez que se va Crear
            If DT_BUSCAR.Rows.Count = 0 Then
                    db.Insertar(obj)
                Else    'Actualizar Encabezado de la Amortizacion
                    db.Actualizar(obj)
                    'Borrar el Detalle, para volver a generar la tabla                
                    db_Detalle.Borrar(obj_Detalle)
                End If

            For i As Integer = 0 To iVista.DataRowCount - 1

                obj_Detalle.num_amortizacion = iVista.GetRowCellValue(i, "Numero")
                obj_Detalle.Fecha = iVista.GetRowCellValue(i, "Fecha")
                obj_Detalle.Monto_Inicial = iVista.GetRowCellValue(i, "Monto Incial")
                obj_Detalle.Monto_Amortizado = iVista.GetRowCellValue(i, "A Amortizar")

                db_Detalle.Insertar(obj_Detalle)
            Next
            '
            XtraMsg("El Detalle de la Amortizacion se Ha Guardado con Exito")

            DT_Amortiza = db_Amortizaciones.Tabla(cbAmorizaciones.EditValue)
            iGrid.DataSource = DT_Amortiza
        Else
                XtraMsg("La Amoritzación " & cbAmorizaciones.Text.ToString.ToUpper & vbCrLf &
                    " se encuentra en estado " & Estado & ", no se puede modificar.")
        End If



        'cnn = New SqlConnection(Rutinas.AbrirConexion)
        'Dim CodA As Integer

        'Try
        '    cnn.Open()

        '    CodA = Guardar_datos()     'Guardar datos de la amortizacion
        '    Guardar_Detalle(CodA)   'Guardar Detalle de la amortizacion

        '    cnn.Close()

        '    'Me.btnCalcular.Enabled = False
        '    'Me.btnSave.Enabled = False
        '    'Me.btnPrevio.Enabled = True

        '    XtraMsg("El Detalle de la Amortizacion se Ha Guardado con Exito")
        '    'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
        'Catch ex As Exception
        '    XtraMsg("ERROR : " & ex.Message, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btnPrevio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevio.Click

        'If Me.cbNombre.EditValue = 0 Then
        '    XtraMsg("Seleccione Amortización que desea Mostrar")
        '    Exit Sub
        'End If

        'Dim rpt As New rptDetalle_Amortizacion
        'rpt.DataSource = AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
        'frmExportarImprimir.Mostrar(rpt)

        'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
        'frmexportaciongrid.ShowDialog()
        'AmortizacionesDB.IMPRIMIR(frmexportaciongrid.Formato, 1)
        'AmortizacionesDB.ImprimirAmortizacion(cbNombre.EditValue)

        If cbAmorizaciones.EditValue Is Nothing Then
            XtraMsg("Seleccione una Amortización")
            cbAmorizaciones.Focus()
            Exit Sub
        End If
        '
        Dim rpt As New rptDetalle_Amortizacion
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
        '
        AmortizacionesDB.Imprimir(cbAmorizaciones.EditValue, rpt)
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub cmbNombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Fecha_inicio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_inicio.EditValueChanged
        Try
            Me.Fecha_limite.DateTime = Me.Fecha_inicio.DateTime.AddMonths(Me.sPlazo.EditValue - 1)
            GetTasa()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbNombre_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.iGrid.DataSource = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub sPlazo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sPlazo.Validating
        Fecha_limite.DateTime = Me.Fecha_inicio.DateTime.AddMonths(CInt(Me.sPlazo.EditValue - 1))
    End Sub

    Private Sub cbAmorizaciones_EditValueChanged(sender As Object, e As EventArgs) Handles cbAmorizaciones.EditValueChanged
        If Inicio Then Exit Sub
        '
        DT_Amortiza = db_Amortizaciones.Tabla(cbAmorizaciones.EditValue)
        iGrid.DataSource = DT_Amortiza
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Contabilizado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Contabilizado") Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.Green
            Else
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.Pink
            End If
        End If
    End Sub

    Private Sub sPlazo_EditValueChanged(sender As Object, e As EventArgs) Handles sPlazo.EditValueChanged

    End Sub
End Class