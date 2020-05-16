Imports OpenNETCF.Desktop.Communication
Imports System.IO
Imports System.DirectoryServices
Imports System
Imports System.Text
Imports System.Collections
Imports System.Configuration

Public Class FrmImportar
    Dim DtsImportacion As New DataSet
    Dim AdptImportacion As New SqlClient.SqlDataAdapter("SELECT * FROM FALCON_LECTURA_ETIQUETA", Cxion)
    Dim datadapter As New SqlClient.SqlDataAdapter("SELECT c_activo, c_custodio FROM act_activo", Cxion)
    Dim datable As New DataTable
    Dim datview As New DataView
    Dim DEP, CC, OBS, OBS1 As String
    Dim obse As Integer
    Dim fecha As String

    Public miRapi As New RAPI

    Public Function BuscarCentroCosto(ByVal IdCentroCosto As String) As String

        Dim Nsql As String = "SELECT *                                        " & _
                             "FROM    con_cat_ctr                             " & _
                             "WHERE  (c_ctr = '" & IdCentroCosto & "')        "

        Dim Cn As New SqlConnection(StrCxion)
        Dim Comm As New SqlCommand(Nsql, Cn)
        Dim dr As SqlDataReader
        Try
            Cn.Open()
            dr = Comm.ExecuteReader
            If dr.Read Then
                Return dr("d_ctr")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Cn.Close()
        End Try
    End Function

    Public Function BuscarUbicacion(ByVal IdCentroCosto As String) As String

        Dim Nsql As String = "SELECT distinct  *                             " & _
                             "FROM    act_cat_custodios                      " & _
                             "WHERE  (c_ctr = '" & IdCentroCosto & "')       "

        Dim Cn As New SqlConnection(StrCxion)
        Dim Comm As New SqlCommand(Nsql, Cn)
        Dim dr As SqlDataReader
        Try
            Cn.Open()
            dr = Comm.ExecuteReader
            If dr.Read Then
                Return dr("c_ubicacion")
                End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Cn.Close()
            End Try
    End Function
    

    Private Sub FrmImportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DtpDesde.Properties.ShowToday = True
        Me.DtpDesde.DateTime = Now
        Me.DtpHasta.Properties.ShowToday = True
        Me.DtpHasta.DateTime = Now
        fecha = Now
        datadapter.Fill(datable)
        datview = datable.DefaultView
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub CkbTodosAFLeidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkbTodosAFLeidos.CheckedChanged
        If Me.CkbTodosAFLeidos.Checked = True Then
            Me.DtpDesde.Enabled = False
            Me.DtpHasta.Enabled = False
        Else
            Me.DtpDesde.Enabled = True
            Me.DtpHasta.Enabled = True
        End If
    End Sub

    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click
        Dim i As Integer
        Dim Cmd As New SqlClient.SqlCommand
        Dim Filtro, CodSG As String
        Dim DtvImportacion As New DataView
        Try
            If miRapi.DevicePresent = True Then
                miRapi.Connect()
            Else
                MessageBox.Show("La PDA esta desconectada, por favor conecte el dispositivo e intente de nuevo", "Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If (CDate(Me.DtpDesde.Text) <= CDate(Me.DtpHasta.Text)) = True Or Me.CkbTodosAFLeidos.Checked = True Then
                
                Try
                    If File.Exists(Application.StartupPath & "\Xml\Importacion\FALCON_LECTURA_ETIQUETA_IMP.xml") Then
                        File.Delete(Application.StartupPath & "\Xml\Importacion\FALCON_LECTURA_ETIQUETA_IMP.xml")
                    End If
                    miRapi.CopyFileFromDevice(Application.StartupPath & "\Xml\Importacion\FALCON_LECTURA_ETIQUETA_IMP.xml", "\My Documents\XML_ACTIVOFIJO\IMPORTACION\FALCON_LECTURA_ETIQUETA_IMP.xml")
                    'miRapi.DeleteDeviceFile("\My Documents\XML_INISER\IMPORTACION\FALCON_LECTURA_ETIQUETA_IMP.xml")
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox("No se encuentran registros importados", MsgBoxStyle.Information)
                    Exit Sub
                End Try
                'Definición de Inventario
                '************************************************'
                Dim frm As New FrmInventarios
                frm.ShowDialog()
                If Inven = "" Then
                    Exit Sub
                End If
                'Cerrar todos los inventarios
                Cmd.Connection = Cxion
                Cmd.CommandType = CommandType.Text
                Cmd.CommandText = " UPDATE [dbo].[FALCON_LECTURA_ETIQUETA] SET [INVENTARIADO] = 1"


                If Cxion.State = ConnectionState.Closed Then
                    Cxion.Open()
                End If
                Cmd.Prepare()
                Cmd.ExecuteNonQuery()
                '************************************************'
                DtsImportacion.ReadXml(Application.StartupPath & "\Xml\Importacion\FALCON_LECTURA_ETIQUETA_IMP.xml", XmlReadMode.Auto)
                File.Delete(Application.StartupPath & "\Xml\Importacion\FALCON_LECTURA_ETIQUETA_IMP.xml")
                AdptImportacion.Fill(DtsImportacion, "FALCON_LECTURA_ETIQUETA")
                Dim FilaVF As DataRow() = DtsImportacion.Tables("FALCON_LECTURA_ETIQUETA").Select("OBS = 'ALTA'")

                Me.PbrImportacion.Properties.Minimum = 0
                Me.PbrImportacion.Properties.Maximum = 2
                Me.PbrImportacion.Properties.Step = 1

                Me.PbrImportacion.PerformStep()
                Me.LblImportacion.Text = "Leyendo ..."
                Me.LblImportacion.Refresh()

                DtvImportacion = DtsImportacion.Tables("FALCON_LECTURA_ETIQUETA_IMP").DefaultView 'ACTIVOS

                Me.PbrImportacion.PerformStep()
                Me.LblImportacion.Text = ""
                Me.LblImportacion.Refresh()

             
                If Me.CkbTodosAFLeidos.Checked = False Then
                    Filtro = "FECHA >= '" & Format(CDate(Me.DtpDesde.Text), "dd/MM/yyyy")
                    Filtro &= "' AND FECHA <= '" & Format(CDate(Me.DtpHasta.Text), "dd/MM/yyyy") & "'"
                    DtvImportacion.RowFilter = Filtro
                End If

                If DtvImportacion.Count <> 0 Then
                    Me.PbrImportacion.EditValue = 0
                    Me.PbrImportacion.Properties.Maximum = DtvImportacion.Count

                    For i = 0 To DtvImportacion.Count - 1
                        Me.LblControl.Text = (i + 1) & " Activos de " & DtvImportacion.Count
                        Me.LblControl.Refresh()
                        CodSG = DtvImportacion.Item(i)("COD_ACTIVO")
                        DEP = DtvImportacion.Item(i)("CODIGO_DEP")
                        CC = DtvImportacion.Item(i)("COD_CENT_COSTO2")
                        OBS = "ALTA"
                        OBS1 = DtvImportacion.Item(i)("OBS")
                        obse = StrComp(OBS, OBS1, CompareMethod.Text)
                        If obse <> -1 Then
                            Dim s As String
                            's = "FECHA  >= '" & Format(CDate(DtvImportacion.Item(i)("FECHA")), "MM/dd/yyyy") & "'" & _
                            '" AND COD_EMPRESA = '" + DtvImportacion.Item(i)("COD_EMPRESA") + "'" + _
                            '" AND GRUPO = '" + DtvImportacion.Item(i)("CODIGO_PARTE") + "'" + _
                            '" AND CONSECU = '" + DtvImportacion.Item(i)("COD_ACTIVO") + "'"
                            'FilaVF = DtsImportacion.Tables("FALCON_LECTURA_ETIQUETA").Select(s) --->> QUITAR CODIGO PARTE
                            s = "FECHA  >= '" & Format(CDate(DtvImportacion.Item(i)("FECHA")), "MM/dd/yyyy") & "'" & _
                           " AND COD_EMPRESA = '" + DtvImportacion.Item(i)("COD_EMPRESA") + "'" + _
                           " AND CONSECU = '" + DtvImportacion.Item(i)("COD_ACTIVO") + "'"
                            FilaVF = DtsImportacion.Tables("FALCON_LECTURA_ETIQUETA").Select(s)
                        End If

                        If FilaVF.Length = 0 Or obse = -1 Then  'FilaVF de activos en bd escritorio
                            Dim Fila As DataRow() = DtsInterfazAF.Tables("ACTIVOS").Select("COD_EMPRESA = '" + DtvImportacion.Item(i)("COD_EMPRESA") + "'" + _
                              " AND CONSECU = '" + DtvImportacion.Item(i)("COD_ACTIVO") + "'")
                            '" AND GRUPO = '" + DtvImportacion.Item(i)("CODIGO_PARTE") + "'" + _

                            If obse = -1 Then
                                If Fila.Length <> 0 Then
                                    '  DtvImportacion.Item(i)("COD_EMPRESA") = CodSG.Substring(0, 2)
                                    DtvImportacion.Item(i)("COD_EMPRESA") = Fila(0)("COD_EMPRESA")
                                    'DtvImportacion.Item(i)("GRUPO") = CodSG.Substring(2, 2)
                                    'DtvImportacion.Item(i)("SUB_GPO") = CodSG.Substring(4, 2)
                                    'DtvImportacion.Item(i)("CONSECU") = CodSG
                                    DtvImportacion.Item(i)("NO_EMP") = Str(Fila(0)("NO_EMP"))
                                    DtvImportacion.Item(i)("DESCRIPCION") = Fila(0)("DESCRIPCION")
                                    DtvImportacion.Item(i)("ESTADO") = Fila(0)("ESTADO")
                                    'DtvImportacion.Item(i)("MODELO") = Fila(0)("MODELO")
                                    'DtvImportacion.Item(i)("SERIE") = Fila(0)("SERIE")
                                    'DtvImportacion.Item(i)("MARCA") = Fila(0)("MARCA")
                                    DtvImportacion.Item(i)("CODIGO_DEP") = Fila(0)("CODIGO_DEP")
                                    DtvImportacion.Item(i)("COD_CENT_COSTO") = Fila(0)("COD_CENT_COSTO")
                                    '  DtvImportacion.Item(i)("CHASIS") = Fila(0)("CHASIS")
                                    ' DtvImportacion.Item(i)("PLACA") = Fila(0)("PLACA")
                                    'DtvImportacion.Item(i)("CIRCULACION") = Fila(0)("CIRCULACION")
                                    ' DtvImportacion.Item(i)("OBS") = Fila(0)("OBS")
                                    'DtvImportacion.Item(i)("ENCONTRADO") = Fila(0)("VERIFICADOR")
                                End If
                            End If
                            If Fila.Length <> 0 Then
                                Try
                                    'Cmd.CommandText = "INSERT INTO FALCON_LECTURA_ETIQUETA " & _
                                    '                                   " (FECHA,COD_EMPRESA,GRUPO,CONSECU,NO_EMP,DESCRIPCION,ESTADO,MODELO,SERIE,MARCA,CODIGO_DEP,COD_CENT_COSTO,ENCONTRADO,OBS,NO_EMP2,DEP_LEIDO,CC_LEIDO,DES_GPO,ID_INV) " + _
                                    '                                                     " VALUES ('" & DtvImportacion.Item(i)("FECHA") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("COD_EMPRESA") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("CODIGO_PARTE") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("COD_ACTIVO") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("NO_EMP") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("DESCRIPCION") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("ESTADO") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("MODELO") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("SERIE") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("MARCA") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("CODIGO_DEP") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("COD_CENT_COSTO") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("ENCONTRADO") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("OBS") & "','" & _
                                    '                                                    DtvImportacion.Item(i)("NO_EMP2") & "','" & _
                                    '                                                    DEP & "','" & _
                                    '                                                    CC & "','" & _
                                    '                                                    DtvImportacion.Item(i)("DES_GPO") & "','" & _
                                    '                                                    Inven & "')"
                                    Cmd.CommandText = "INSERT INTO FALCON_LECTURA_ETIQUETA " & _
                                                                      " (FECHA,COD_EMPRESA,CONSECU,NO_EMP,DESCRIPCION,ESTADO,MODELO,SERIE,MARCA,CODIGO_DEP,COD_CENT_COSTO,ENCONTRADO,OBS,NO_EMP2,DEP_LEIDO,CC_LEIDO,DES_GPO,ID_INV,Usuario) " + _
                                                                                        " VALUES ('" & DtvImportacion.Item(i)("FECHA") & "','" & _
                                                                                     Trim(DtvImportacion.Item(i)("COD_EMPRESA")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("COD_ACTIVO")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("NO_EMP")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("DESCRIPCION")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("ESTADO")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("MODELO")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("SERIE")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("MARCA")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("CODIGO_DEP")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("COD_CENT_COSTO")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("ENCONTRADO")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("OBS")) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("NO_EMP2")) & "','" & _
                                                                                      Trim(DEP) & "','" & _
                                                                                      Trim(CC) & "','" & _
                                                                                      Trim(DtvImportacion.Item(i)("DES_GPO")) & "','" & _
                                                                                       Inven & "' , '" & _
                                                                                       Trim(DtvImportacion.Item(i)("usuario")) & "')"

                                    If Cxion.State = ConnectionState.Closed Then
                                        Cxion.Open()
                                    End If
                                    Cmd.Prepare()
                                    Cmd.ExecuteNonQuery()
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
                            Else
                                If Fila.Length = 0 Then
                                    Try
                                        'Cmd.CommandText = "INSERT INTO FALCON_LECTURA_ETIQUETA " & _
                                        '                               " (FECHA,COD_EMPRESA,GRUPO,CONSECU,NO_EMP,DESCRIPCION,ESTADO,MODELO,SERIE,MARCA,CODIGO_DEP,COD_CENT_COSTO,ENCONTRADO,OBS,NO_EMP2,DEP_LEIDO,CC_LEIDO,DES_GPO,ID_INV) " + _
                                        '                                                 " VALUES ('" & DtvImportacion.Item(i)("FECHA") & "','" & _
                                        '                                                DtvImportacion.Item(i)("COD_EMPRESA") & "','" & _
                                        '                                                DtvImportacion.Item(i)("CODIGO_PARTE") & "','" & _
                                        '                                                DtvImportacion.Item(i)("COD_ACTIVO") & "','" & _
                                        '                                                DtvImportacion.Item(i)("NO_EMP") & "','" & _
                                        '                                                DtvImportacion.Item(i)("DESCRIPCION") & "','" & _
                                        '                                                DtvImportacion.Item(i)("ESTADO") & "','" & _
                                        '                                                DtvImportacion.Item(i)("MODELO") & "','" & _
                                        '                                                DtvImportacion.Item(i)("SERIE") & "','" & _
                                        '                                                DtvImportacion.Item(i)("MARCA") & "','" & _
                                        '                                                DtvImportacion.Item(i)("CODIGO_DEP") & "','" & _
                                        '                                                DtvImportacion.Item(i)("COD_CENT_COSTO") & "','" & _
                                        '                                                DtvImportacion.Item(i)("ENCONTRADO") & "','" & _
                                        '                                                DtvImportacion.Item(i)("OBS") & "','" & _
                                        '                                                DtvImportacion.Item(i)("NO_EMP2") & "','" & _
                                        '                                                DEP & "','" & _
                                        '                                                CC & "','" & _
                                        '                                                DtvImportacion.Item(i)("DES_GPO") & "','" & _
                                        '                                                Inven & "')"
                                        Cmd.CommandText = "INSERT INTO FALCON_LECTURA_ETIQUETA " & _
                                                                      " (FECHA,COD_EMPRESA,CONSECU,NO_EMP,DESCRIPCION,ESTADO,MODELO,SERIE,MARCA,CODIGO_DEP,COD_CENT_COSTO,ENCONTRADO,OBS,NO_EMP2,DEP_LEIDO,CC_LEIDO,DES_GPO,ID_INV, Usuario) " + _
                                                                                        " VALUES ('" & DtvImportacion.Item(i)("FECHA") & "','" & _
                                                                                       DtvImportacion.Item(i)("COD_EMPRESA") & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("COD_ACTIVO")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("NO_EMP")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("DESCRIPCION")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("ESTADO")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("MODELO")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("SERIE")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("MARCA")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("CODIGO_DEP")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("COD_CENT_COSTO")) & "','" & _
                                                                                       DtvImportacion.Item(i)("ENCONTRADO") & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("OBS")) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("NO_EMP2")) & "','" & _
                                                                                       Trim(DEP) & "','" & _
                                                                                       Trim(CC) & "','" & _
                                                                                       Trim(DtvImportacion.Item(i)("DES_GPO")) & "','" & _
                                                                                      Inven & "' , '" & _
                                                                                       Trim(DtvImportacion.Item(i)("usuario")) & "')"
                                        If Cxion.State = ConnectionState.Closed Then
                                            Cxion.Open()
                                        End If
                                        Cmd.Prepare()
                                        Cmd.ExecuteNonQuery()
                                        If Cxion.State = ConnectionState.Open Then
                                            Cxion.Close()
                                        End If
                                    Catch ex As Exception
                                        MsgBox(ex.Message)
                                    End Try
                                End If
                            End If
                            Me.PbrImportacion.PerformStep()
                            'Me.LblImportacion.Text = DtvImportacion.Item(i)("COD_EMPRESA") + "-" + _
                            '                         DtvImportacion.Item(i)("CODIGO_PARTE") + "-" + _
                            '                         DtvImportacion.Item(i)("COD_ACTIVO") + "  " + _
                            '                         DtvImportacion.Item(i)("DESCRIPCION")
                            Me.LblImportacion.Text = DtvImportacion.Item(i)("COD_EMPRESA") + "-" + _
                                                     DtvImportacion.Item(i)("COD_ACTIVO") + "  " + _
                                                     DtvImportacion.Item(i)("DESCRIPCION")
                            Me.LblImportacion.Refresh()
                        Else
                            Me.PbrImportacion.PerformStep()
                        End If
                        'Esto nos busca si verdaderamente el Alta levantada es un Alta
                        If Trim(DtvImportacion.Item(i)("OBS").ToString) = "ALTA" Then
                            datview.RowFilter = "c_activo = '" & DtvImportacion.Item(i)("COD_ACTIVO").ToString & "'"
                            If datview.Count > 0 Then
                                Dim com As New SqlClient.SqlCommand
                                com.Connection = Cxion
                                com.CommandType = CommandType.Text
                                com.CommandText = "UPDATE FALCON_LECTURA_ETIQUETA SET NO_EMP = '" & Trim(datview.Item(0)("c_custodio")).ToString & "', OBS = ''" & _
                                                           " WHERE CONSECU = '" & DtvImportacion.Item(i)("COD_ACTIVO").ToString & "'"
                                If Cxion.State = ConnectionState.Closed Then
                                    Cxion.Open()
                                End If
                                com.Prepare()
                                com.ExecuteNonQuery()
                                If Cxion.State = ConnectionState.Open Then
                                    Cxion.Close()
                                End If
                            End If
                            datview.RowFilter = ""
                        End If
                        'Fin de comprobación de Alta
                    Next
                    DtvImportacion = Nothing
                    Me.LblImportacion.Text = "Finalizado"
                    MsgBox("La importación de las lecturas se finalizó con éxito", MsgBoxStyle.Information)
                    Me.LblImportacion.Text = ""
                    Me.LblControl.Text = ""
                    Me.PbrImportacion.EditValue = 0
                Else
                    MsgBox("Para el rango de fecha seleccionado no existen lecturas de activos fijos registrados", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                MsgBox("La fecha de Inicio debe ser menor o igual que la fehca de Fin", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'Nuevo Importar: PARA IMPORTAR TRASLADOS 
            If ckbTRASLADOS.Checked = True Then

                Try
                    If File.Exists(Application.StartupPath & "\Xml\Importacion\TRASLADOS.xml") Then
                        File.Delete(Application.StartupPath & "\Xml\Importacion\TRASLADOS.xml")
                    End If
                    miRapi.CopyFileFromDevice(Application.StartupPath & "\Xml\Importacion\TRASLADOS.xml", "\My Documents\XML_ACTIVOFIJO\IMPORTACION\TRASLADOS.xml")
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox("No se encuentran registros de traslados importados", MsgBoxStyle.Information)
                    Exit Sub
                End Try


                'Definición de Inventario
                '************************************************'
                If String.IsNullOrEmpty(Inven) Then
                    Dim frm As New FrmInventarios
                    frm.ShowDialog()
                    If Inven = "" Then
                        Exit Sub
                    End If
                End If
                '************************************************'

                Dim daTraslados As New SqlClient.SqlDataAdapter("Select Activo, Custodio_Ini, Custodio_Fin from act_traslados where Inventario='" & Inven & "'", Cxion)
                Dim dtImportTraslados As New DataSet
                Dim dvImportTraslados As New DataView

               

                dtImportTraslados.ReadXml(Application.StartupPath & "\Xml\Importacion\TRASLADOS.xml", XmlReadMode.Auto)
                File.Delete(Application.StartupPath & "\Xml\Importacion\TRASLADOS.xml")

                If dtImportTraslados.Tables("ACTIVOS_TRASLADOS").Rows.Count < 1 Then
                    MsgBox("No hay registro de traslado de activos para importar.", vbExclamation, "SIAF-LAFISE")
                    Exit Sub
                End If

                Try


                    daTraslados.Fill(dtImportTraslados, "TRASLADOS_LEIDOS")
                    dvImportTraslados = dtImportTraslados.Tables("TRASLADOS_LEIDOS").DefaultView

                    Dim cmdInser As New SqlClient.SqlCommand
                    Dim transa As SqlClient.SqlTransaction
                    If Cxion.State = ConnectionState.Closed Then
                        Cxion.Open()
                    End If

                    cmdInser = Cxion.CreateCommand
                    transa = Cxion.BeginTransaction
                    cmdInser.Transaction = transa

                    Dim FilaTras As DataRow
                    'dvImportTraslados = dtImportTraslados.Tables("TRASLADOS").DefaultView


                    For i = 0 To dtImportTraslados.Tables("ACTIVOS_TRASLADOS").Rows.Count - 1
                        FilaTras = dtImportTraslados.Tables("ACTIVOS_TRASLADOS").Rows(i)

                        dvImportTraslados.RowFilter = String.Format("Activo='{0}' and Custodio_Ini='{1}' and Custodio_Fin='{2}'", _
                                              Trim(FilaTras("Activo").ToString), Trim(FilaTras("Custodio_I").ToString), _
                                             Trim(FilaTras("Custodio_F").ToString))
                        If dvImportTraslados.Count = 0 Then

                            cmdInser.CommandText = String.Format( _
                                "INSERT INTO act_traslados (Custodio_Ini, Custodio_Fin, CC_I, CC_F, Ubicacion_Ini, Ubicacion_Fin, Fecha, " & _
                                "Motivo, Activo, Inventario, Usuario) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}','{10}')", _
                           Trim(FilaTras("Custodio_I")), Trim(FilaTras("Custodio_F")), Trim(FilaTras("CC_I")), Trim(FilaTras("CC_F")), _
                           Trim(FilaTras("Ubicacion_I")), Trim(FilaTras("Ubicacion_f")), Trim(FilaTras("Fecha")), _
                           Trim(FilaTras("Motivo")), Trim(FilaTras("Activo")), Inven, Trim(FilaTras("usuario")))

                            cmdInser.Prepare()
                            cmdInser.ExecuteNonQuery()
                        End If
                    Next
                    transa.Commit()
                    MsgBox("La importacion de las lecturas de traslados se han importado con exito.", vbInformation, "SIAF-LAFISE")
                Catch ex As Exception
                    MsgBox("Error al guardar Traslados de activos: " & ex.Message, vbCritical, "SIAF-LAFISE")
                End Try

            End If


            'Nuevo Importar: PARA IMPORTAR EMPLEADOS NUEVOS


            Try
                If File.Exists(Application.StartupPath & "\Xml\Importacion\EMPLEADOSNUEVOS.xml") Then
                    File.Delete(Application.StartupPath & "\Xml\Importacion\EMPLEADOSNUEVOS.xml")
                End If
                miRapi.CopyFileFromDevice(Application.StartupPath & "\Xml\Importacion\EMPLEADOSNUEVOS.xml", "\My Documents\XML_ACTIVOFIJO\IMPORTACION\EMPLEADOSNUEVOS.xml")
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("No se encuentran registros de Empleados nuevos importados", MsgBoxStyle.Information)
                Exit Sub
            End Try


            'Definición de Inventario
            '************************************************'
            If String.IsNullOrEmpty(Inven) Then
                Dim frm As New FrmInventarios
                frm.ShowDialog()
                If Inven = "" Then
                    Exit Sub
                End If
            End If
            '************************************************'

            'Dim daempleadosnueovs As New SqlClient.SqlDataAdapter("Select Activo, Custodio_Ini, Custodio_Fin from act_traslados where Inventario='" & Inven & "'", Cxion)
            Dim dtImportEmpleadosNuevos As New DataSet




            dtImportEmpleadosNuevos.ReadXml(Application.StartupPath & "\Xml\Importacion\EMPLEADOSNUEVOS.xml", XmlReadMode.Auto)
            File.Delete(Application.StartupPath & "\Xml\Importacion\EMPLEADOSNUEVOS.xml")

            If dtImportEmpleadosNuevos.Tables("EMPLEADOS").Rows.Count < 1 Then
                MsgBox("No hay registro de empleados nuevos para importar.", vbExclamation, "SIAF-LAFISE")
                Exit Sub
            End If

            Try


           

                Dim cmdInser As New SqlClient.SqlCommand
                Dim transa As SqlClient.SqlTransaction
                If Cxion.State = ConnectionState.Closed Then
                    Cxion.Open()
                End If

                cmdInser = Cxion.CreateCommand
                transa = Cxion.BeginTransaction
                cmdInser.Transaction = transa

                Dim FilaTras As DataRow
                'dvImportTraslados = dtImportTraslados.Tables("TRASLADOS").DefaultView


                For i = 0 To dtImportEmpleadosNuevos.Tables("EMPLEADOS").Rows.Count - 1
                    FilaTras = dtImportEmpleadosNuevos.Tables("EMPLEADOS").Rows(i)

                 
                    cmdInser.CommandText = String.Format( _
                        "  INSERT INTO act_cat_custodios (c_ctr, d_ctr, c_custodio,  d_custodio, c_ubicacion) " & _
                        "  VALUES ('{0}','{1}','{2}','{3}',{4})", _
                           Trim(FilaTras("CENTROCOSTO")), BuscarCentroCosto(FilaTras("CENTROCOSTO")), Trim(FilaTras("NO_EMP")), Trim(FilaTras("NOMBRE")), BuscarUbicacion(FilaTras("CENTROCOSTO")))

                    cmdInser.Prepare()
                    cmdInser.ExecuteNonQuery()

                Next
                transa.Commit()
                MsgBox("La importacion de las lecturas de empleados nuevos se han importado con exito.", vbInformation, "SIAF-LAFISE")
            Catch ex As Exception
                MsgBox("Error al guardar Traslados de activos: " & ex.Message, vbCritical, "SIAF-LAFISE")
            End Try














        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If DtsImportacion.Tables.Contains("FALCON_LECTURA_ETIQUETA") Then DtsImportacion.Tables("FALCON_LECTURA_ETIQUETA").Clear()
        If DtsImportacion.Tables.Contains("FALCON_LECTURA_ETIQUETA_IMP") Then DtsImportacion.Tables("FALCON_LECTURA_ETIQUETA_IMP").Clear()
        Me.Close()
        If Cxion.State = ConnectionState.Open Then
            Cxion.Close()
        End If

    End Sub
End Class