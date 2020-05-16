Imports System.IO
Public Class FrmExportar
    Inherits DevExpress.XtraEditors.XtraForm
    Dim DtvCentroCosto As New DataView
    Dim DtvActivos As New DataView
    Dim DtvDependencias As New DataView
    Dim DtsExpAct As New DataSet
    Dim nombre As String
    Dim exportado As Boolean
    Private Sub FrmExportar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            DtsInterfaz.Tables("CENTRO_COSTO").Columns.Remove(" ")
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub FrmExportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'INICIALIZACIONES
            DtvCentroCosto = DtsInterfaz.Tables("CENTRO_COSTO").DefaultView
            Dim cuant As Integer = DtsInterfaz.Tables("CENTRO_COSTO").Rows.Count
            DtvActivos = DtsInterfazAF.Tables("ACTIVOS").DefaultView
            DtvDependencias = DtsInterfaz.Tables("DEPENDENCIA").DefaultView
            'INICIALIZACIONES
            'DtvDependencias.RowFilter = "c_empresa = " & 1
            Agrgar_Col_CC()



            Me.CmbDependencia.DataSource = DtvDependencias
            'Me.CmbDependencia.DisplayMember = "d_ctr"
           
            Me.CmbDependencia.DisplayMember = "Descripcion"
            Me.CmbDependencia.SelectedIndex = 0

            With CmbDependencia2.Properties
                .DataSource = DtvDependencias
                .DisplayMember = "Descripcion"
                .ValueMember = "Codigo"
                .View.Columns("Codigo").Visible = False
                .View.Columns("cod_empresa").Visible = False

            End With

            CmbDependencia2.Text = "10"
            Me.TdbCentroCosto.DataSource = Nothing
            Me.CkbTodosAF.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Agrgar_Col_CC()
        Dim DCol As DataColumn
        DCol = New DataColumn
        DCol.ColumnName = " "
        DCol.DataType = System.Type.GetType("System.Boolean")
        DCol.DefaultValue = False
        DCol.Unique = False
        DtsInterfaz.Tables("CENTRO_COSTO").Columns.Add(DCol)
    End Sub

    Private Sub CkbTodosAF_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CkbTodosAF.CheckedChanged
        Try
            If CkbTodosAF.Checked = True Then
                Me.CmbDependencia.Enabled = False
                Me.CmbDependencia2.Enabled = False
                Me.TdbCentroCosto.Enabled = False
                Me.TdbCentroCosto.DataSource = Nothing
            Else
                Me.CmbDependencia2.Enabled = True
                Me.CmbDependencia.Enabled = True
                Me.TdbCentroCosto.Enabled = True
                Me.TdbCentroCosto.DataSource = DtvCentroCosto
                Formato_Grid_CC()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Formato_Grid_CC()

        Me.TdbCentroCosto.Columns(" ").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.TdbCentroCosto.Splits(0).DisplayColumns(" ").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TdbCentroCosto.Splits(0).DisplayColumns(" ").HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TdbCentroCosto.Splits(0).DisplayColumns(" ").Width = 20
        Me.TdbCentroCosto.ExtendRightColumn = True

        Me.TdbCentroCosto.Splits(0).DisplayColumns("CODIGO_ANTERIOR").Width = 80
        Me.TdbCentroCosto.Splits(0).DisplayColumns("DES_CENT_COSTO").Width = 210
        Me.TdbCentroCosto.Splits(0).DisplayColumns("DES_CENT_COSTO").DataColumn.Caption = "NOMBRE CENTRO DE COSTO"
        Me.TdbCentroCosto.Splits(0).DisplayColumns("CODIGO_ANTERIOR").DataColumn.Caption = "CODIGO"
        Me.TdbCentroCosto.Splits(0).DisplayColumns(0).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns(1).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns(2).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns(3).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns(4).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns(5).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns(6).Visible = False
        ' Me.TdbCentroCosto.Splits(0).DisplayColumns(7).Visible = False
        'Me.TdbCentroCosto.Splits(0).DisplayColumns(8).Visible = False
        'Me.TdbCentroCosto.Splits(0).DisplayColumns(9).Visible = False
        'Me.TdbCentroCosto.Splits(0).DisplayColumns(10).Visible = False
        'Me.TdbCentroCosto.Splits(0).DisplayColumns(11).Visible = False
        'Me.TdbCentroCosto.Splits(0).DisplayColumns(12).Visible = False
        Me.TdbCentroCosto.Splits(0).DisplayColumns("CODIGO_ANTERIOR").Visible = True
        Me.TdbCentroCosto.Splits(0).DisplayColumns("DES_CENT_COSTO").Visible = True
    End Sub

    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click

        Dim DtsExpAct As New DataSet
        Dim Filtro, AgF, OpFOR, OpFAND As String
        Dim i, j, k, l, Band, clen As Integer
        Try
            l = 0
            If miRapi.DevicePresent = True Then
                miRapi.Connect()
            Else
                MessageBox.Show("La PDA esta desconectada, por favor conecte el dispositivo e intente de nuevo", "SIAF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Filtro = ""
            Adpt.Fill(DtsInterfaz, "TEMPUSUARIOS")
            AgF = " COD_CENT_COSTO = "
            OpFOR = " OR "
            OpFAND = " AND "

            For i = 0 To DtsInterfaz.Tables("CENTRO_COSTO").Rows.Count - 1
                If DtsInterfaz.Tables("CENTRO_COSTO").Rows(i)(" ") = True Then
                    If Band = 0 Then
                        clen = DtsInterfaz.Tables("CENTRO_COSTO").Rows(i)("CODIGO_ANTERIOR").ToString.Length 'Parte nueva para validar el tamaño del dato
                        Filtro = "(" + AgF + "'" + Trim(DtsInterfaz.Tables("CENTRO_COSTO").Rows(i)("CODIGO_ANTERIOR").ToString) + "'" + OpFAND + "CODIGO_DEP = " + "'" + Trim(DtsInterfaz.Tables("CENTRO_COSTO").Rows(i)("CODIGO_DEP").ToString) + "'" + ")"
                    Else
                        Filtro = Filtro + OpFOR + "(" + AgF + "'" + Trim(DtsInterfaz.Tables("CENTRO_COSTO").Rows(i)("CODIGO_ANTERIOR").ToString) + "'" + OpFAND + "CODIGO_DEP = " + "'" + Trim(DtsInterfaz.Tables("CENTRO_COSTO").Rows(i)("CODIGO_DEP").ToString) + "'" + ")"
                    End If
                    Band += 1
                End If
            Next

            If Band = 0 And CkbTodosAF.Checked = False Then
                MsgBox("Por favor debe seleccionar al menos un centro de costo", MsgBoxStyle.Information)
                Exit Sub
            End If

            DtvActivos.RowFilter = ""
            DtvActivos.RowFilter = "NO_EMP='744'"
            DtvActivos.RowFilter = "NO_EMP='78'"
            DtvActivos.RowFilter = "NO_EMP='1541'"
            DtvActivos.RowFilter = Filtro


            DtsExpAct.Clear()
            DtsExpAct.ReadXmlSchema(Application.StartupPath & "\XML\ESQUEMA_EACTVIO.xml")

            If Me.CkbTodosAF.Checked = True Then
                DtvActivos.RowFilter = Nothing
                DtvActivos = DtsInterfazAF.Tables("ACTIVOS").DefaultView
            End If

            Me.PbrExportacion.Properties.Minimum = 0
            Me.PbrExportacion.Properties.Maximum = DtvActivos.Count + 3
            Me.PbrExportacion.Properties.Step = 1

            Me.LblExportacion.Text = "Exportando Empleados hacia el PDA"
            Me.LblExportacion.Refresh()
            Me.PbrExportacion.PerformStep()

            Me.LblExportacion.Text = "Exportando Dependecias hacia el PDA"
            Me.LblExportacion.Refresh()
            Me.PbrExportacion.PerformStep()

            Me.LblExportacion.Text = "Exportando Centros de Costos hacia el PDA"
            Me.LblExportacion.Refresh()
            Me.PbrExportacion.PerformStep()

            'RECREANDO DIRECTORIOS EN PDA
            Try
                'Creando carpeta XML_ACTIVOFIJO
                'If Not miRapi.DeviceFileExists("\My Documents\XML_ACTIVOFIJO\") Then
                '    miRapi.CreateDeviceDirectory("\My Documents\XML_ACTIVOFIJO\")
                'End If

                If miRapi.DeviceFileExists("My Documents\XML_ACTIVOFIJO\FALCON_LECTURA_ETIQUETA1.xml") Then
                    miRapi.RemoveDeviceDirectory("My Documents\XML_ACTIVOFIJO", True)
                End If
                If Not miRapi.DeviceFileExists("\My Documents\XML_ACTIVOFIJO\FALCON_LECTURA_ETIQUETA1.xml") Then
                    miRapi.CreateDeviceDirectory("\My Documents\XML_ACTIVOFIJO\")
                End If
            Catch ex As Exception
                If StrComp(ex.Message.ToUpper.Trim, "could not create directory".ToUpper) = -1 Then
                    MsgBox(String.Format("Error Directorys PDA: {0} detalle: {1} error:", ex.Message, ex.StackTrace), MsgBoxStyle.Critical, "SIAF")
                End If
            End Try

            'FIN DE RECREACION

2:          ' i = i ?????
            'Dim Dept As String = Nothing
            For i = l To DtvActivos.Count - 1

                Dim newrow As DataRow

                LblContador.Text = Str(i + 1) & " Activos de " & DtvActivos.Count
                LblContador.Refresh()

                newrow = DtsExpAct.Tables("FALCON_LECTURA_ETIQUETA").NewRow
                newrow("FECHA") = Format(DateTime.Now, "dd/MM/yyyy")
                newrow("COD_EMPRESA") = DtvActivos.Item(i).Item("COD_EMPRESA")
                'newrow("GRUPO") = (DtvActivos.Item(i).Item("GRUPO"))
                'newrow("DES_GPO") = Trim(DtvActivos.Item(i).Item("DES_GPO"))
                newrow("CONSECU") = DtvActivos.Item(i).Item("CONSECU")
                newrow("NO_EMP") = Trim(DtvActivos.Item(i).Item("NO_EMP"))
                newrow("DESCRIPCION") = Trim(DtvActivos.Item(i).Item("DESCRIPCION"))
                newrow("ESTADO") = Trim(DtvActivos.Item(i).Item("ESTADO"))
                'newrow("MODELO") = Trim(DtvActivos.Item(i).Item("MODELO"))
                'newrow("SERIE") = Trim(DtvActivos.Item(i).Item("SERIE"))
                'newrow("COD_MARCA") = Trim(DtvActivos.Item(i).Item("COD_MARCA"))
                ''newrow("MARCA") = Trim(DtvActivos.Item(i).Item("MARCA"))

                'Linea Modificada Pedro
                'newrow("CODIGO_DEP") = (Mid(Trim(DtvActivos.Item(i).Item("CODIGO_DEP")), 1, 3)) 
                If IsDBNull(DtvActivos.Item(i).Item("CODIGO_DEP")) Then
                    newrow("CODIGO_DEP") = ""
                Else
                    newrow("CODIGO_DEP") = (Mid(Trim(DtvActivos.Item(i).Item("CODIGO_DEP")), 1, 3))
                End If

                'Linea Modificada Pedro
                'newrow("COD_CENT_COSTO") = Trim(DtvActivos.Item(i).Item("COD_CENT_COSTO"))
                If IsDBNull(DtvActivos.Item(i).Item("COD_CENT_COSTO")) Then
                    newrow("COD_CENT_COSTO") = ""
                Else
                    newrow("COD_CENT_COSTO") = Trim(DtvActivos.Item(i).Item("COD_CENT_COSTO"))
                End If


                'newrow("OBS") = ""
                newrow("ENCONTRADO") = "--"
                newrow("COD_ACTIVO") = Trim(DtvActivos.Item(i).Item("COD_ACTIVO"))
                newrow("COD_ACTIVO_AUX") = Trim(DtvActivos.Item(i).Item("COD_ACTIVO"))
                DtsExpAct.Tables("FALCON_LECTURA_ETIQUETA").Rows.Add(newrow)

                Me.PbrExportacion.PerformStep()
                Me.LblExportacion.Text = DtvActivos.Item(i).Item(0) & " " & DtvActivos.Item(i).Item(1) & " " & DtvActivos.Item(i).Item(2) & " " & DtvActivos.Item(i).Item(4)
                Me.LblExportacion.Refresh()
                j = j + 1
                If j = 500 Then
                    k = k + 1
                    nombre = "FALCON_LECTURA_ETIQUETA" & k & ".xml"
                    GoTo 1
                End If
            Next
            k = k + 1
            nombre = "FALCON_LECTURA_ETIQUETA" & k & ".xml"
            If Me.CkbCatalogos.Checked = True Then
                DtsInterfaz.WriteXml(Application.StartupPath & "\Xml\Exportacion\CC_EMPLEADOS.xml", XmlWriteMode.WriteSchema)
                Try
                    miRapi.CopyFileToDevice(Application.StartupPath & "\Xml\Exportacion\CC_EMPLEADOS.xml", "My Documents\XML_ACTIVOFIJO\CC_EMPLEADOS.xml")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            'Posición para partir los XML en varios (1:)
1:
            DtsExpAct.WriteXml(Application.StartupPath & "\Xml\Exportacion\" & nombre, XmlWriteMode.WriteSchema)

            Try
                miRapi.CopyFileToDevice(Application.StartupPath & "\Xml\Exportacion\" & nombre, "My Documents\XML_ACTIVOFIJO\" & nombre)
                If i < DtvActivos.Count Then
                    DtsExpAct.Clear()
                    j = 0
                    l = i + 1
                    GoTo 2
                End If
                exportado = True
            Catch ex As Exception
                MsgBox(ex.Message)
                exportado = False
            End Try
            miRapi.Disconnect()

            If exportado Then
                MsgBox("Los registros se han exportado satisfactoriamente", MsgBoxStyle.Information)
            Else
                MsgBox("Elimine exportaciones anteriores en la PDA y repita el proceso de exportación", MsgBoxStyle.Information)
            End If
            DtsInterfaz.Tables("CENTRO_COSTO").Columns.Remove(" ")
            Agrgar_Col_CC()
            Me.TdbCentroCosto.DataSource = Nothing

            Me.CkbTodosAF.Checked = True
            Me.PbrExportacion.EditValue = 0
            Me.PbrExportacion.Refresh()
            Me.LblExportacion.Text = ""
            Me.LblContador.Text = ""

            DtsInterfaz.Tables("TEMPUSUARIOS").Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TdbCentroCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CmbDependencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDependencia.SelectedIndexChanged
        Dim p As Integer
        Try
            'DtvCentroCosto.RowFilter = "SUBSTRING(c_ctr,1,3) = '" & Trim(DtsInterfaz.Tables("DEPENDENCIA").Rows(Me.CmbDependencia.SelectedIndex)("c_ctr")) & "'" & " AND (len (c_ctr)) > 4"
            DtvCentroCosto.RowFilter = "CODIGO_DEP= '" & Trim(DtsInterfaz.Tables("DEPENDENCIA").Rows(Me.CmbDependencia.SelectedIndex)("Codigo")) & "'"
            Me.TdbCentroCosto.DataSource = DtvCentroCosto
            If p = 0 Then
                'Formato_Grid_CC()
                p += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  

    
    Private Sub CmbDependencia2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDependencia2.EditValueChanged
        Dim p As Integer
        Try
            'DtvCentroCosto.RowFilter = "SUBSTRING(c_ctr,1,3) = '" & Trim(DtsInterfaz.Tables("DEPENDENCIA").Rows(Me.CmbDependencia.SelectedIndex)("c_ctr")) & "'" & " AND (len (c_ctr)) > 4"
            'If CmbDependencia2.EditValue = "'_'" Then
            '    Exit Sub

            'End If
            DtvCentroCosto.RowFilter = "CODIGO_DEP= '" & CmbDependencia2.EditValue & "'"
            Me.TdbCentroCosto.DataSource = DtvCentroCosto
            If p = 0 Then
                'Formato_Grid_CC()
                p += 1
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

  
End Class