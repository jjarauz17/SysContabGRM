Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraBars

Module funciones

    Enum Tiempos
        TiempoInicio
        TiempoFin
    End Enum

    Enum Eventos
        Inicia
        Guarda
        Error1
        Anula
        Salir
    End Enum

    Public Function ProcedureSave(ByVal Parametros As ArrayList, ByVal Variables As ArrayList, ByVal Procedimiento As String) As Boolean
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure
        Dim Parametro(Parametros.Count) As SqlParameter
        For i As Integer = 0 To Parametros.Count - 1
            Parametro(i) = New SqlParameter("@" & Variables(i).ToString, TipoDatos(Parametros(i).GetType))
            Parametro(i).Value = Parametros(i)
            Command.Parameters.Add(Parametro(i))
        Next
        Try
            DC.Open()
            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            XtraMsg("Error :" & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            DC.Close()
        End Try
    End Function

    Public Function GetChequeDb(ByVal Periodo As Integer, ByVal Comprobante As Integer, ByVal Fecha As DateTime, ByVal ValorLetra As String) As DataTable

        Dim DT As New DataTable
        Dim DC As New SqlCommand("SpCreaCheque")
        Dim Con As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim PPer As New SqlParameter("@PerId", SqlDbType.Int)
        Dim PComp As New SqlParameter("@CompNo", SqlDbType.Int)
        Dim PEmp As New SqlParameter("@Empresa", SqlDbType.Int)
        Dim PFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
        Dim PValor As New SqlParameter("@Letras", SqlDbType.NVarChar, 250)
        Dim PUsuario As New SqlParameter("@Usuario", SqlDbType.NVarChar, 250)

        PPer.Value = Periodo
        PComp.Value = Comprobante
        PFecha.Value = Fecha
        PEmp.Value = EmpresaActual
        PValor.Value = ValorLetra
        PUsuario.Value = Login

        DC.CommandType = CommandType.StoredProcedure
        DC.Connection = Con
        DC.Parameters.Add(PPer)
        DC.Parameters.Add(PComp)
        DC.Parameters.Add(PFecha)
        DC.Parameters.Add(PEmp)
        DC.Parameters.Add(PValor)
        DC.Parameters.Add(PUsuario)

        Dim DA As New SqlDataAdapter(DC)
        DA.Fill(DT)
        Return DT
    End Function

    Public Sub SetTiempos_NO_USAR_NO_SIRVE_PARA_NADA(ByVal Modulo As OrigenComprobantes, ByVal Tiempo As Tiempos, ByVal Hora As DateTime,
    ByVal Evento As Eventos, Optional ByVal Documento As String = vbNullString)
        Dim Con As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim Comando As New SqlCommand("SPGuardaAuditTiempos", Con)
        Comando.CommandType = CommandType.StoredProcedure
        Dim P1 As New SqlParameter("@IdModulo", SqlDbType.Int)
        P1.Value = Modulo
        Dim P2 As New SqlParameter("@Empresa", SqlDbType.Int)
        P2.Value = EmpresaActual
        Dim P3 As New SqlParameter("@NoDocumento", SqlDbType.NVarChar, 20)
        P3.Value = Documento
        Dim P4 As New SqlParameter("@Hora", SqlDbType.DateTime)
        P4.Value = Hora.ToString
        Dim P5 As New SqlParameter("@IdAccion", SqlDbType.Int)
        P5.Value = Evento
        Comando.Parameters.Add(P1)
        Comando.Parameters.Add(P2)
        Comando.Parameters.Add(P3)
        Comando.Parameters.Add(P4)
        Comando.Parameters.Add(P5)

        Try
            Con.Open()
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub

    Public Function ObtieneDatos(ByVal StrSQL As String) As DataTable
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim DA As New SqlDataAdapter(StrSQL, DC)
        Dim DT As New DataTable

        Try
            DA.SelectCommand.CommandTimeout = 0
            DA.Fill(DT)
            Return DT

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Function ObtieneDatosTN(ByVal Procedimiento As String,
                            TableName As String,
                            ByVal ParamArray Parametros() As Object) As DataTable

        Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim dt As New DataTable(TableName)
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cmd.CommandText = Procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cn.Open()
        cmd.Connection = cn
        da.SelectCommand = cmd

        SqlCommandBuilder.DeriveParameters(cmd)
        Try
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try


        Try
            da.Fill(dt)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        da = Nothing
        cmd = Nothing
        cn.Close()

        Return dt
    End Function

    Function ObtieneDatos(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataTable

        Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cmd.CommandText = Procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cn.Open()
        cmd.Connection = cn
        da.SelectCommand = cmd

        SqlCommandBuilder.DeriveParameters(cmd)

        Try
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try


        Try
            da.Fill(dt)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        da = Nothing
        cmd = Nothing
        cn.Close()

        Return dt
    End Function

    Function ObtieneDatosTrans(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataTable

        'Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cmd.CommandText = Procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0

        'cn.Open()
        'cmd.Connection = cn
        'da.SelectCommand = cmd

        cmd.Connection = DBConnFacturas
        cmd.Transaction = transaccionFacturas
        da.SelectCommand = cmd
        SqlCommandBuilder.DeriveParameters(cmd)

        Try
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try


        Try
            da.SelectCommand.CommandTimeout = 0
            da.SelectCommand.Connection = DBConnFacturas
            da.SelectCommand.Transaction = transaccionFacturas
            da.Fill(dt)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        da = Nothing
        cmd = Nothing
        'cn.Close()

        Return dt
    End Function

    Public Sub LimpiarControles(ByRef frm As DevExpress.XtraEditors.XtraForm)
        'For Each Con As Control In Forma.Controls
        '    If TypeOf Con Is TextBox Then Con.Text = vbNullString
        '    If TypeOf Con Is ComboBox Then CType(Con, ComboBox).SelectedIndex = -1
        'Next
        For Each Con As Control In frm.Controls
            If Con.HasChildren Then
                For Each Cont As Control In Con.Controls
                    If TypeOf Cont Is DevExpress.XtraEditors.TextEdit Then Cont.Text = vbNullString
                    If TypeOf Cont Is DevExpress.XtraEditors.LookUpEdit Then Cont.Text = vbNullString
                Next
            End If
            If TypeOf Con Is DevExpress.XtraEditors.TextEdit Then Con.Text = vbNullString
            If TypeOf Con Is DevExpress.XtraEditors.LookUpEdit Then Con.Text = vbNullString
        Next
    End Sub

    Public Sub LimpiarControles(ByVal ly As DevExpress.XtraLayout.LayoutControl)
        Try
            For Each c As Object In ly.Controls  '' Nivel 1
                If TypeOf c Is DevExpress.XtraEditors.TextEdit Then c.EditValue = vbNullString
                If TypeOf c Is DevExpress.XtraEditors.LookUpEdit Then c.EditValue = Nothing
                If TypeOf c Is DevExpress.XtraEditors.GridLookUpEdit Then c.EditValue = Nothing
                If TypeOf c Is DevExpress.XtraEditors.SearchLookUpEdit Then c.EditValue = Nothing

                If TypeOf c Is TextBox Then c.Text = Nothing
            Next
        Catch ex As Exception
        End Try
    End Sub


    Public Function GuardaDatos(ByVal StrSQL As String, Optional ByVal Transaccion As Boolean = False) As Boolean
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

        Try
            Dim DCom As New SqlCommand(StrSQL, DC)
            DC.Open()
            DCom.CommandTimeout = 0
            DCom.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message & vbCrLf &
                   StrSQL, MessageBoxIcon.Error)
            Return False
        Finally
            DC.Close()
        End Try
    End Function

    Public Function GuardaDatosTrans(ByVal StrSQL As String) As Boolean
        Try

            Dim DCom As New SqlCommand(StrSQL, DBConnFacturas)
            DCom.Connection = DBConnFacturas
            DCom.Transaction = transaccionFacturas
            DCom.CommandTimeout = 0
            DCom.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message & vbCrLf &
                    StrSQL, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function Guardar_Con_Transaccion(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Boolean
        Try
            ' Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            Dim cmd As New SqlCommand

            cmd.CommandText = Procedimiento
            cmd.CommandType = CommandType.StoredProcedure

            ' cn.Open()
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.CommandTimeout = 0

            SqlCommandBuilder.DeriveParameters(cmd)
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If

            cmd.ExecuteNonQuery()
            cmd = Nothing
            ' cn.Close()

            Return True
        Catch ex As Exception
            XtraMsg("SP: " & Procedimiento & vbCrLf & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ProcedureParameters(ByVal Parametros As ArrayList, ByVal Variables As ArrayList,
                                        ByVal Procedimiento As String) As DataTable

        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure

        If Not Parametros Is Nothing Then
            Dim Parametro(Parametros.Count) As SqlParameter
            For i As Integer = 0 To Parametros.Count - 1
                Parametro(i) = New SqlParameter("@" & Variables(i).ToString, TipoDatos(Parametros(i).GetType))
                Parametro(i).Value = Parametros(i)
                Command.Parameters.Add(Parametro(i))
            Next
        End If

        Try
            DC.Open()
            Dim DA As New SqlDataAdapter(Command)
            DA.SelectCommand.CommandTimeout = 0
            DA.Fill(DT)

        Catch ex As Exception
            XtraMsg("Error :" & ex.Message & vbCrLf &
                    Procedimiento, MessageBoxIcon.Error)
            Throw New Exception
        Finally
            DC.Close()
        End Try
        Return DT
    End Function

    Function TipoDatos(ByVal Value As Type) As SqlDbType
        Select Case Value.Name
            Case "String" : Return SqlDbType.NVarChar
            Case "Int32" : Return SqlDbType.Int
            Case "Double" : Return SqlDbType.Money
            Case "Decimal" : Return SqlDbType.Money
            Case "DateTime" : Return SqlDbType.SmallDateTime
        End Select
    End Function

    Public Sub EliminaDistribucion(ByVal Comprobante As Integer, ByVal Periodo As Integer, ByVal Mes As Integer, Optional Trans As Boolean = False)
        Try
            If Not Trans Then
                GuardaDatos("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & Comprobante & " AND Mes = " & Mes & " AND Per_Id = " & Periodo)
            Else
                GuardaDatosTrans("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & Comprobante & " AND Mes = " & Mes & " AND Per_Id = " & Periodo)
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''
    Public Sub EliminaDistribucionTrans(ByVal Comprobante As Integer, ByVal Periodo As Integer, ByVal Mes As Integer)
        Try
            GuardaDatosTrans("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & Comprobante & " AND Mes = " & Mes & " AND Per_Id = " & Periodo)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GuardaDistribucionTrans(ByVal DT_Distribucion As DataTable,
                                       ByVal Fecha As Date,
                                       Optional ByVal Comprobante As String = vbNullString)
        Dim i As Integer
        Dim DT_F As DataTable
        DT_F = DT_Distribucion.GetChanges(DataRowState.Deleted)
        If Not DT_F Is Nothing Then
            For i = 0 To DT_F.Rows.Count - 1
                With DT_F
                    If DT_F.Rows(i).RowState = DataRowState.Deleted Then
                        Dim Fila As DataRow = DT_F.Rows(i)
                        GuardaDatosTrans("DELETE FROM Distribucion WHERE IdDetalle = " & Fila("IdDetalle", DataRowVersion.Original))
                    End If
                End With
            Next
        End If
        If Not DT_F Is Nothing Then DT_F.Clear()
        DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified)
        If Not DT_F Is Nothing Then
            For i = 0 To DT_F.Rows.Count - 1
                With DT_F
                    If DT_F.Rows(i).RowState = DataRowState.Added Then
                        GuardaDatosTrans("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                        " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & "," & Fecha.Month & "," &
                        VB.SysContab.PeriodosDB.Activo(Fecha.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                    ElseIf DT_F.Rows(i).RowState = DataRowState.Modified Then
                        GuardaDatosTrans("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & ",Mes=" & Fecha.Month & "," &
                        "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.Date) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                        "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                    End If
                End With
            Next
        End If
    End Sub

    Public Function CargaDistribucionTrans(ByVal Mes As Integer, ByVal Comprobante As String, ByVal Periodo As Integer) As DataTable
        Return ObtieneDatosTrans("SELECT * FROM Distribucion WHERE Mes = " & Mes & " AND NoComp = '" & Comprobante & "' AND IdEmpresa = " & EmpresaActual & " AND Per_Id = " & Periodo)
    End Function

    Public Sub GuardaDistribucion(ByVal DT_Distribucion As DataTable, ByVal Fecha As Date, Optional ByVal Comprobante As String = vbNullString)
        Dim i As Integer
        Dim DT_F As DataTable
        DT_F = DT_Distribucion.GetChanges(DataRowState.Deleted)
        If Not DT_F Is Nothing Then
            For i = 0 To DT_F.Rows.Count - 1
                With DT_F
                    If DT_F.Rows(i).RowState = DataRowState.Deleted Then
                        Dim Fila As DataRow = DT_F.Rows(i)
                        GuardaDatos("DELETE FROM Distribucion WHERE IdDetalle = " & Fila("IdDetalle", DataRowVersion.Original))
                    End If
                End With
            Next
        End If
        If Not DT_F Is Nothing Then DT_F.Clear()
        DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified)
        If Not DT_F Is Nothing Then
            For i = 0 To DT_F.Rows.Count - 1
                With DT_F
                    If DT_F.Rows(i).RowState = DataRowState.Added Then
                        GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
                        " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & "," & Fecha.Month & "," & _
                        VB.SysContab.PeriodosDB.Activo(Fecha.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                    ElseIf DT_F.Rows(i).RowState = DataRowState.Modified Then
                        GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & ",Mes=" & Fecha.Month & "," & _
                        "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.Date) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," & _
                        "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                    End If
                End With
            Next
        End If
    End Sub

    Public Function CargaDistribucion(ByVal Mes As Integer, ByVal Comprobante As String, ByVal Periodo As Integer) As DataTable
        Return ObtieneDatos("SELECT * FROM Distribucion WHERE Mes = " & Mes & " AND NoComp = '" & Comprobante & "' AND IdEmpresa = " & EmpresaActual & " AND Per_Id = " & Periodo)
    End Function

    Public Function IsNull(ByVal Var, Optional ByVal Valor = vbNullString)
        If IsDBNull(Var) OrElse IsNothing(Var) OrElse Var = vbNullString OrElse Var = Nothing Then
            Return IIf(IsNothing(Valor), "", Valor)
        Else
            Return Var
        End If
    End Function

    Public Sub GetClientesList(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
        combo.Properties.DataSource = ObtieneDatos("SP_GetClientes " & EmpresaActual & "," & TodosClientes)
        combo.Properties.DisplayMember = "Nombre"
        combo.Properties.ValueMember = "Codigo"
        combo.Properties.PopulateColumns()

        combo.Properties.Columns(0).Visible = False
        For i As Integer = 3 To combo.Properties.Columns.Count - 1
            combo.Properties.Columns(i).Visible = False
        Next
        combo.Properties.ShowFooter = False
    End Sub

    Public Sub GetMonedasList(ByVal combo As DevExpress.XtraEditors.LookUpEdit)

        Dim Tasa As New VB.SysContab.Tasa_CambioDB
        combo.Properties.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles.Tables("Tasa_Cambio")
        combo.Properties.ValueMember = "MonedaCambio"
        combo.Properties.DisplayMember = "Nombre"
        combo.Properties.PopulateColumns()

        combo.Properties.NullText = "[Seleccione Moneda]"
        combo.Properties.ShowHeader = False
        combo.Properties.ShowFooter = False

        Try
            For i As Integer = 0 To combo.Properties.Columns.Count - 1
                combo.Properties.Columns(i).Visible = False
            Next
            '
            combo.Properties.Columns(3).Visible = True
            combo.Properties.SearchMode = Controls.SearchMode.AutoFilter
            combo.EditValue = MonedaBase
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetMonedas(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
        combo.Properties.DataSource = ObtieneDatos("SELECT m.mon_codigo, m.mon_descripcion, m.mon_simbolo FROM Monedas m WHERE m.empr_codigo = " & EmpresaActual)
        combo.Properties.ValueMember = "mon_codigo"
        combo.Properties.DisplayMember = "mon_descripcion"
        combo.Properties.PopulateColumns()
        combo.Properties.NullText = "[Seleccione Moneda]"
        combo.Properties.ShowHeader = False
        combo.Properties.ShowFooter = False
        combo.Properties.Columns(0).Visible = False
    End Sub

    Public Function GetCultivo() As DataTable

        Return ObtieneDatos("SELECT tc.IdDetalle Codigo, tc.Codigo + ' - '  + tc.Nombre Nombre FROM TipoCultivo AS tc WHERE tc.Empresa = " & EmpresaActual)

    End Function


    Public Sub GetItemMonedasList(ByVal combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        Dim Tasa As New VB.SysContab.Tasa_CambioDB
        combo.DataSource = Tasa.GetListTasaCambioDisponibles.Tables("Tasa_Cambio")
        combo.ValueMember = "MonedaCambio"
        combo.DisplayMember = "Nombre"
        combo.PopulateColumns()
        combo.Columns(0).Visible = False
        combo.Columns(1).Visible = False
        combo.Columns(2).Visible = False
    End Sub

    Public Sub GetFormaPagoList(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
        Dim FormaPago As New VB.SysContab.Forma_PagoDB
        combo.Properties.DataSource = ObtieneDatos("SP_formaPagoList " & EmpresaActual)
        combo.Properties.ValueMember = "Codigo"
        combo.Properties.DisplayMember = "Nombre"
        combo.Properties.PopulateColumns()
        combo.Properties.NullText = "[Forma de Pago]"
        '
        For i As Integer = 0 To combo.Properties.Columns.Count - 1
            combo.Properties.Columns(i).Visible = False
        Next
        '
        combo.Properties.Columns("Nombre").Visible = True
        combo.Properties.SearchMode = Controls.SearchMode.AutoFilter
    End Sub

    Public Sub GetFormaPagoListAll(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
        Dim FormaPago As New VB.SysContab.Forma_PagoDB
        combo.Properties.DataSource = ObtieneDatos("_FormaPagoListAll " & EmpresaActual)
        combo.Properties.ValueMember = "Codigo"
        combo.Properties.DisplayMember = "Nombre"
        combo.Properties.PopulateColumns()
        combo.Properties.NullText = "[Forma de Pago]"

        For i As Integer = 0 To combo.Properties.Columns.Count - 1
            combo.Properties.Columns(i).Visible = False
        Next
        '
        combo.Properties.Columns("Nombre").Visible = True
        combo.ItemIndex = 0
    End Sub

    Public Sub GetCajasFacturacion(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("SELECT 0 Codigo,'--- Todas ---' Caja,'' [PC Nombre] UNION" _
                                                   + " SELECT c.cj_Codigo Codigo,c.cj_Nombre Caja,c.pc_Nombre [PC Nombre] FROM CAJAS c WHERE c.Empresa_ID = " & EmpresaActual).DefaultView
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Caja"
        cb.Properties.PopulateColumns()
        cb.Properties.Columns(0).Visible = False
        cb.ItemIndex = 0
    End Sub

    Public Sub GetClientesContado(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
        combo.Properties.DataSource = _
        ObtieneDatos("SELECT c.CODIGO,c.CodigoLetra [CODIGO LETRA],c.NOMBRE FROM CLIENTES c INNER JOIN FORMA_PAGO fp" _
                     + " ON c.COD_FORMA_PAGO = fp.CODIGO AND c.EMPRESA = fp.EMPRESA" _
                     + " WHERE fp.DIAS = 0 AND c.EMPRESA = " & EmpresaActual)

        combo.Properties.ValueMember = "CODIGO"
        combo.Properties.DisplayMember = "NOMBRE"
        combo.Properties.PopulateColumns()
        combo.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        'combo.Properties.Columns(0).Visible = False
    End Sub

    Public Sub GetTipoCultivo(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
        'combo.Properties.DataSource = ObtieneDatos("SELECT '' Codigo,'[Seleccione Cultivo]' Nombre UNION ALL SELECT t.Codigo,t.Nombre FROM TipoCultivo t WITH (NOLOCK) WHERE Empresa = " & EmpresaActual)
        'combo.Properties.ValueMember = "Codigo"
        'combo.Properties.DisplayMember = "Nombre"
        'combo.Properties.PopulateColumns()
        '
        combo.Properties.DataSource = ObtieneDatos("sp_sel_Cultivos", EmpresaActual)
        combo.Properties.ValueMember = "Codigo"
        combo.Properties.DisplayMember = "Nombre"
        combo.Properties.PopulateColumns()

        combo.Properties.NullText = "[Seleccione Cultivo]"
        combo.Properties.ShowHeader = True
        combo.Properties.ShowFooter = False
        '
        combo.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        combo.ItemIndex = 0
    End Sub

    Public Sub GetTipoComprobantesList(ByVal combo As DevExpress.XtraEditors.LookUpEdit, Optional Todo As Integer = 0)

        Dim comp As New VB.SysContab.ComprobanteDB
        combo.Properties.DataSource = ObtieneDatos("SP_TipoComprobantesList",
                                                   EmpresaActual,
                                                   Todo)
        combo.Properties.ValueMember = "TipComp_Id"
        combo.Properties.DisplayMember = "TipComp_Nombre"
        combo.Properties.PopulateColumns()
        combo.Properties.NullText = "[Tipo de Comprobante]"
        combo.Properties.Columns(0).Visible = False
        combo.Properties.Columns(2).Visible = False
        combo.Properties.Columns(3).Visible = False
        '
        combo.Properties.ShowHeader = False
        combo.Properties.ShowFooter = False


        'Dim comp As New VB.SysContab.ComprobanteDB
        'combo.Properties.DataSource = ObtieneDatos("SP_TipoComprobantesList " & EmpresaActual)
        'combo.Properties.ValueMember = "TipComp_Id"
        'combo.Properties.DisplayMember = "TipComp_Nombre"
        'combo.Properties.PopulateColumns()
        'combo.Properties.Columns(0).Visible = False
        'combo.Properties.Columns(2).Visible = False
        'combo.Properties.Columns(3).Visible = False
    End Sub

    Public Sub GetBodegasList(ByVal combo As DevExpress.XtraEditors.LookUpEdit)

        Dim Bodega As New VB.SysContab.BodegasDB
        combo.Properties.DataSource = Bodega.GetList()
        combo.Properties.ValueMember = "CODIGO"
        combo.Properties.DisplayMember = "UBICACION"
        combo.Properties.PopulateColumns()

        For i As Integer = 0 To combo.Properties.Columns.Count - 1
            combo.Properties.Columns(i).Visible = False
        Next

        combo.Properties.NullText = "[Seleccione Bodega]"
        combo.Properties.Columns("UBICACION").Visible = True
        combo.Properties.ShowHeader = False
        combo.Properties.ShowFooter = False
    End Sub

    Public Sub GetBodegasList(ByVal combo As DevExpress.XtraEditors.CheckedComboBoxEdit)
        'Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        'ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        'Dim Bodega As New VB.SysContab.BodegasDB
        'combo.Properties.DataSource = Bodega.GetList().Tables(0)
        'combo.Properties.ValueMember = "CODIGO"
        'combo.Properties.DisplayMember = "UBICACION"

        combo.Properties.DataSource = ObtieneDatos("sp_Bodegas_Lista", EmpresaActual)
        combo.Properties.ValueMember = "CODIGO"
        combo.Properties.DisplayMember = "UBICACION"

        combo.Properties.NullText = "[Seleccione Bodega]"
        ' combo.CheckAll()
        'combo.SetEditValue(ConfigDetalles.Bodega)
        'combo.Properties.Columns("UBICACION").Visible = True
        'combo.Properties.ShowHeader = False
        'combo.Properties.ShowFooter = False
    End Sub

    Public Sub GetBodegasxUsuario(ByVal combo As DevExpress.XtraEditors.CheckedComboBoxEdit)
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        'Dim Bodega As New VB.SysContab.BodegasDB
        'combo.Properties.DataSource = Bodega.GetList().Tables(0)
        'combo.Properties.ValueMember = "CODIGO"
        'combo.Properties.DisplayMember = "UBICACION"

        combo.Properties.DataSource = ObtieneDatos("JAR_GetBodegasxUsuario", EmpresaActual)
        combo.Properties.ValueMember = "CODIGO"
        combo.Properties.DisplayMember = "BODEGA"

        combo.Properties.NullText = "[Seleccione Bodega]"
        ' combo.CheckAll()
        combo.SetEditValue(ConfigDetalles.Bodega)
        'combo.Properties.Columns("UBICACION").Visible = True
        'combo.Properties.ShowHeader = False
        'combo.Properties.ShowFooter = False
    End Sub

    Public Sub GetBodegasxUsuario(ByVal combo As DevExpress.XtraEditors.LookUpEdit, Todo As Integer)
        combo.Properties.DataSource = ObtieneDatos("JAR_GetBodegasxUsuario", EmpresaActual, Todo)
        combo.Properties.ValueMember = "CODIGO"
        combo.Properties.DisplayMember = "BODEGA"
        combo.Properties.PopulateColumns()

        combo.Properties.NullText = "[Seleccione Bodega]"
        combo.Properties.Columns("CODIGO").Visible = False
        combo.Properties.ShowHeader = False
        combo.Properties.ShowFooter = False
    End Sub

    Public Sub GetBodegasxUsuario(ByVal combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, Todo As Integer)

        combo.DataSource = ObtieneDatos("JAR_GetBodegasxUsuario", EmpresaActual, Todo)
        combo.ValueMember = "CODIGO"
        combo.DisplayMember = "BODEGA"
        combo.PopulateColumns()

        combo.NullText = "[Seleccione Bodega]"
        combo.Columns("CODIGO").Visible = False
        combo.ShowHeader = False
    End Sub

    Public Function GetCostoPromedioProducto(Codigo As String, Tipo As String, Bodega As String) As Double
        Dim DT As DataTable = ObtieneDatos("JAR_GetCostoProducto", Codigo, Tipo, Bodega, EmpresaActual)

        If DT.Rows.Count = 0 Then
            Return 0.0
        End If

        Return DT.Rows.Item(0)("Promedio")

    End Function


    'Public Sub GetBodegasList_Inventario(ByVal combo As DevExpress.XtraEditors.LookUpEdit)
    '    'Dim Bodega As New VB.SysContab.BodegasDB
    '    combo.Properties.DataSource = ObtieneDatos("SELECT '0' CODIGO, '[Todas]' UBICACION UNION ALL SELECT Codigo_Bodega AS CODIGO, Codigo_Bodega + ' - ' + Ubicacion UBICACION FROM BODEGAS WHERE BODEGAS.Empresa =" & EmpresaActual)
    '    combo.Properties.ValueMember = "CODIGO"
    '    combo.Properties.DisplayMember = "UBICACION"
    '    combo.Properties.PopulateColumns()
    '    combo.Properties.Columns(0).Visible = False
    '    'combo.Properties.Columns(2).Visible = False
    'End Sub

    Public Sub GetCentrosCostosList(ByVal cb As DevExpress.XtraEditors.CheckedComboBoxEdit)
        'cb.Properties.DataSource = ObtieneDatos("SELECT CAST(cdc.Codigo AS NVARCHAR(10)) Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
        '                                          + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual)

        cb.Properties.DataSource = ObtieneDatos("sp_sel_CentroDeCosto", 0, 0, EmpresaActual)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
    End Sub

    Public Sub GetSucursales_CheckList(ByVal cb As DevExpress.XtraEditors.CheckedComboBoxEdit)
        cb.Properties.DataSource = ObtieneDatos("sp_GetSucursalesClientesxBodega " & EmpresaActual)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
    End Sub

    Public Sub GetSucursales(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("sp_GetSucursalesClientesxBodega " & EmpresaActual)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.NullText = "[Sucursal]"
        cb.Properties.ShowHeader = False
        cb.Properties.ShowFooter = False
        ' cb.Properties.Columns(0).Visible = False
    End Sub

    Public Sub GetTipoMovimientos(ByVal cb As DevExpress.XtraEditors.LookUpEdit, Nuevo As Integer)

        LookUp(cb, ObtieneDatos("sp_Get_TipoMovimientos", EmpresaActual, Nuevo), "Nombre", "Codigo", "[Tipo Movimiento]", 0, 3)

        'cb.Properties.DataSource = ObtieneDatos("SELECT cast(0 as int) ID, '[Seleccione Movimiento]' Nombre, '' Cuenta UNION SELECT t.ID,t.Nombre,t.Cuenta FROM TipoMovimientos t WHERE t.Empresa = " & EmpresaActual)
        'cb.Properties.ValueMember = "ID"
        'cb.Properties.DisplayMember = "Nombre"
        'cb.Properties.PopulateColumns()
        'cb.Properties.Columns(0).Visible = False
    End Sub

    'Public Sub GetClientesCategorias(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
    '    cb.Properties.DataSource = ObtieneDatos("JAR_GetClientesCategoria " & EmpresaActual)
    '    cb.Properties.ValueMember = "IdCategoria"
    '    cb.Properties.DisplayMember = "Nombre"
    '    cb.Properties.PopulateColumns()
    '    ' cb.Properties.Columns(0).Visible = False
    'End Sub

    Public Sub GetCentrosCostosList(ByVal cb As DevExpress.XtraEditors.LookUpEdit, Optional op As Integer = 0)
        'If op = 0 Then _
        'cb.Properties.DataSource = ObtieneDatos("SELECT cdc.Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
        '                                           + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual & " ORDER BY cdc.Nombre")

        'If op <> 0 Then _
        'cb.Properties.DataSource = ObtieneDatos("SELECT 0 Codigo, '[Centro Costo]' Nombre UNION ALL SELECT cdc.Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
        '                                           + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual & " ORDER BY Codigo")


        cb.Properties.DataSource = ObtieneDatos("sp_sel_CentroDeCosto", 0, op, EmpresaActual)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.NullText = "[Seleccione Centro Costo]"
        cb.Properties.Columns("Codigo").Visible = False
        cb.Properties.Columns("Bodega").Visible = False

        'cb.Properties.Columns("Codigo").Visible = False
        cb.ItemIndex = 0
        cb.Properties.ShowHeader = False
        cb.Properties.ShowFooter = False
    End Sub

    Public Sub GetCentrosCostosList(ByVal cb As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        cb.DataSource = ObtieneDatos("sp_sel_CentroDeCosto", 0, 0, EmpresaActual)
        cb.ValueMember = "Codigo"
        cb.DisplayMember = "Nombre"
        cb.PopulateColumns()
        cb.NullText = "[Seleccione Centro Costo]"
        cb.Columns("Codigo").Visible = False
        cb.Columns("Bodega").Visible = False
        '
        cb.ShowHeader = False
        cb.ShowFooter = False
    End Sub

    Public Sub GetConsignatarios(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("SELECT c.IdDetalle, c.Nombre, c.Descripcion FROM Consignatarios c WHERE c.Empresa = " & EmpresaActual)
        cb.Properties.ValueMember = "IdDetalle"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.Columns("IdDetalle").Visible = False
    End Sub

    Public Sub GetAgencias(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("SELECT c.IdDetalle, c.Nombre, c.Descripcion FROM Agencias c WHERE c.Empresa = " & EmpresaActual)
        cb.Properties.ValueMember = "IdDetalle"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.Columns("IdDetalle").Visible = False
    End Sub

    Public Sub GetMetodosEnvio(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("SELECT c.IdDetalle, c.Nombre, c.Descripcion FROM Metodos_Envio c WHERE c.Empresa = " & EmpresaActual)
        cb.Properties.ValueMember = "IdDetalle"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.Columns("IdDetalle").Visible = False
    End Sub

    Public Sub GetCondicionesVenta(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("JAR_GetCondicionesVenta")
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.ItemIndex = 0
    End Sub

    Public Sub GetComprobantesList(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("_TipoComprobantesList '0'," & EmpresaActual).DefaultView
        cb.Properties.ValueMember = "TipComp_Id"
        cb.Properties.DisplayMember = "TipComp_Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.Columns(0).Visible = False
        cb.Properties.Columns(1).Visible = False
        cb.Properties.Columns(3).Visible = False
        cb.Properties.Columns(4).Visible = False
        cb.Properties.Columns(5).Visible = False
        cb.ItemIndex = 0
    End Sub

    Public Sub GeMovimientos_Clases(ByVal combo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal op As Integer = 1)
        combo.Properties.DataSource = ObtieneDatos("SP_GetMovimientosClases " & EmpresaActual & "," & op)
        combo.Properties.ValueMember = "Codigo"
        combo.Properties.DisplayMember = "Nombre"
        combo.Properties.PopulateColumns()
        combo.Properties.Columns(0).Visible = False
        combo.ItemIndex = 0
    End Sub

    Public Sub GetMesesList(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        cb.Properties.ValueMember = "Mes"
        cb.Properties.DisplayMember = "MesAnno"
        cb.Properties.PopulateColumns()

        For i As Integer = 0 To cb.Properties.Columns.Count - 1
            cb.Properties.Columns(i).Visible = False
        Next

        cb.Properties.Columns("MesAnno").Visible = True
        cb.Properties.NullText = "[Seleccione]"
        cb.Properties.ShowHeader = False
        cb.Properties.ShowFooter = False
        cb.EditValue = VB.SysContab.Rutinas.Fecha().Month.ToString
    End Sub

    'Public Sub FormatoGrid(ByRef Grid As DevExpress.XtraGrid.Views.Grid.GridView, Optional OFind As Boolean = True)
    '    For i As Integer = 0 To Grid.Columns.Count - 1
    '        Grid.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '        Grid.Columns(i).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    '        Grid.Columns(i).AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9, FontStyle.Bold)
    '    Next
    '    Grid.OptionsFind.AlwaysVisible = OFind
    '    Grid.OptionsFind.ShowClearButton = False
    'End Sub

    Public Function VerificarCierre(ByVal Fecha As Date) As Boolean
        'Dim FechaCierre As Date

        '        'Verificar la Tabla si tiene datos
        '        Try
        'Verificar:
        '            FechaCierre = CDate(ObtieneDatos("SELECT MAX(Fecha) FROM CierreDia WHERE Empresa = " & EmpresaActual).Rows(0).Item(0))
        '        Catch ex As Exception
        '            GuardaDatos("sp_CierreAdd " & EmpresaActual)
        '            ' XtraMsg("La Tabla CierreDia se encuentra vacia!" & vbCrLf & "Error: " & ex.Message, MessageBoxIcon.Error)
        '            'Return False
        '            GoTo Verificar
        '        End Try
        '

        Dim FechaCierre As Date = BuscarUltimoCierre().Date

        Try
            If Fecha <= FechaCierre Then
                XtraMsg("El Mes se Encuentra Cerrado a la Fecha: " & FechaCierre.ToShortDateString, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function

    Function BuscarUltimoCierre() As Date
        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Output, Now.Date)
            Conn.AddParameter("Cierre", SqlDbType.Int, 5, ParameterDirection.Output, 0)

            Conn.EjecutarComando("JAR_GetUltimoCierre")

            Return Conn.GetParameter("Fecha").Valor
        Catch ex As Exception
            Return VB.SysContab.Rutinas.Fecha().Date
        End Try

    End Function

    Function UltimoCierreInventario() As Date

        Return ObtieneDatos("JAR_GetUltimoCierreInventario", EmpresaActual).Rows.Item(0)("Fecha_Cierre")

    End Function

    Public Function VerificarCierre_Inventario(ByVal Fecha As Date) As Boolean
        Dim DT As DataTable = ObtieneDatos("JAR_ValidarCierreInventario",
                                           EmpresaActual)
        ''
        If DT.Rows.Item(0)("Fecha") Is DBNull.Value Then
            Return True
        End If
        ''
        If Fecha <= DT.Rows.Item(0)("Fecha") Then
            XtraMsg("El Inventario se encuentra Cerrado a la Fecha: " & CDate(DT.Rows.Item(0)("Fecha")).ToShortDateString, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    'Function VerificarCierre() As Date
    '    Try
    '        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

    '        Conn.RemoveParameters()
    '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Output, Now.Date)
    '        Conn.AddParameter("Cierre", SqlDbType.Int, 5, ParameterDirection.Output, 0)

    '        Conn.EjecutarComando("JAR_GetUltimoCierre")

    '        'Cierre = Conn.GetParameter("Cierre").Valor
    '        Return IsNull(Conn.GetParameter("Fecha").Valor, VB.SysContab.Rutinas.Fecha().Date)

    '    Catch ex As Exception
    '        'Cierre = 0
    '        Return VB.SysContab.Rutinas.Fecha().Date
    '    End Try
    'End Function



    Public Function FillDatasetFromGrid(ByVal Data As DataSet, ByVal Grid As DevExpress.XtraGrid.Views.Grid.GridView) As DataSet
        Dim rowHandle As Integer
        Dim gridRow As DataRow
        Dim i As Integer = 0
        Do While i < Grid.RowCount
            rowHandle = Grid.GetVisibleRowHandle(i)
            If (Not Grid.IsGroupRow(rowHandle)) Then
                gridRow = Grid.GetDataRow(rowHandle)
                Data.Tables(0).Rows.Add(gridRow.ItemArray)
            End If
            i += 1
        Loop
        Return Data
    End Function

    Public Function ProcedureParametersDS(ByVal Parametros As ArrayList, ByVal Variables As ArrayList, ByVal Procedimiento As String) As DataSet
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataSet
        Command.CommandType = CommandType.StoredProcedure
        If Not Parametros Is Nothing Then
            Dim Parametro(Parametros.Count) As SqlParameter
            For i As Integer = 0 To Parametros.Count - 1
                Parametro(i) = New SqlParameter("@" & Variables(i).ToString, TipoDatos(Parametros(i).GetType))
                Parametro(i).Value = Parametros(i)
                Command.Parameters.Add(Parametro(i))
            Next
        End If
        Try
            DC.Open()
            Dim DA As New SqlDataAdapter(Command)
            DA.Fill(DT, "Datos")
        Catch ex As Exception
            MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical)
        Finally
            DC.Close()
        End Try
        Return DT
    End Function

    Public Function ObtieneDatosTrans(ByVal StrSQL As String) As DataTable
        'Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

        Dim DA As New SqlDataAdapter(StrSQL, DBConnFacturas)
        Dim DS As New DataTable

        DA.SelectCommand.CommandTimeout = 0
        DA.SelectCommand.Connection = DBConnFacturas
        DA.SelectCommand.Transaction = transaccionFacturas
        DA.Fill(DS)
        Return DS

    End Function

    Public Sub GetCatalogoCuenta(ByVal cb As DevExpress.XtraEditors.GridLookUpEdit,
                                 ByVal Vista As DevExpress.XtraGrid.Views.Grid.GridView)


        GridLookUp(cb, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 3, 1, 0)

        'cb.Properties.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        'cb.Properties.ValueMember = "Cuenta"
        'cb.Properties.DisplayMember = "Display"
        'cb.Properties.PopupFormMinSize = New Point(1000, 0)
        'cb.Properties.PopulateViewColumns()
        ''Vista.PopulateColumns()
        'FormatoGrid(Vista)

        'Vista.Columns("Display").Visible = False
        'Vista.Columns("Cuenta").BestFit()
        'Vista.Columns("Nombre").BestFit()
        'Vista.Columns("NombreCompleto").BestFit()

        'Vista.OptionsBehavior.Editable = False
        'Vista.OptionsView.ShowAutoFilterRow = True
    End Sub

    Public Sub GetCatalogoProveedores(ByVal cb As DevExpress.XtraEditors.GridLookUpEdit, _
                                 ByVal Vista As DevExpress.XtraGrid.Views.Grid.GridView, _
                                 Optional ByVal Todo As Integer = 0)



        GridLookUp(cb, ObtieneDatos("sp_sel_Proveedores", EmpresaActual, Todo), "NOMBRE", "CODIGO", 3, 2, 1, 0)


        'Dim sSQL1 As String = ""

        'If Todo <> 0 Then
        '    sSQL1 = "SELECT CAST(0 AS int) CODIGO,'' [CODIGO LETRA],'--- Todos ---' NOMBRE UNION "
        'End If

        'cb.Properties.DataSource = ObtieneDatos(sSQL1 & "SELECT CAST(p.CODIGO AS int) CODIGO,p.CodigoLetra [CODIGO LETRA],p.NOMBRE FROM PROVEEDORES p" _
        '                                        + " WHERE p.EMPRESA = " & EmpresaActual)
        'cb.Properties.ValueMember = "CODIGO"
        'cb.Properties.DisplayMember = "NOMBRE"
        'cb.Properties.PopulateViewColumns()
        'cb.Properties.PopupFormSize = New Point(800, 0)
        'Vista.PopulateColumns()
        'FormatoGrid(Vista)

        ''Vista.Columns("CODIGO").BestFit()
        ''Vista.Columns("CODIGO LETRA").BestFit()
        ''Vista.Columns("NOMBRE").BestFit()

        'Vista.BestFitColumns()
        'Vista.OptionsBehavior.Editable = False
        'Vista.OptionsView.ShowAutoFilterRow = True
    End Sub

    Public Sub GetCatalogoClientes(ByVal cb As DevExpress.XtraEditors.GridLookUpEdit, _
                                 ByVal Vista As DevExpress.XtraGrid.Views.Grid.GridView)

        cb.Properties.DataSource = ObtieneDatos("SP_GetClientes", EmpresaActual, TodosClientes)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateViewColumns()
        'Vista.PopulateColumns()
        FormatoGrid(Vista)

        For i As Integer = 0 To Vista.Columns.Count - 1
            Vista.Columns(i).Visible = False
        Next

        Vista.Columns("Codigo").Visible = True
        Vista.Columns("CodigoLetra").Visible = True
        Vista.Columns("Nombre").Visible = True

        Vista.Columns("Codigo").BestFit()
        Vista.Columns("CodigoLetra").BestFit()
        Vista.Columns("Nombre").BestFit()

        Vista.Columns("Codigo").VisibleIndex = 0
        Vista.Columns("CodigoLetra").VisibleIndex = 1
        Vista.Columns("Nombre").VisibleIndex = 2

        Vista.OptionsBehavior.Editable = False
        Vista.OptionsView.ShowAutoFilterRow = True
    End Sub

    Public Sub GetCatalogoEmpleados(ByVal cb As DevExpress.XtraEditors.GridLookUpEdit, _
                                 ByVal Vista As DevExpress.XtraGrid.Views.Grid.GridView)

        cb.Properties.DataSource = ObtieneDatos("SELECT e.emp_codigo Codigo,e.emp_pnombre + ' ' + e.emp_snombre + ' ' + e.emp_papellido + ' ' + e.emp_sapellido Nombre," _
                                                + " e.emp_codigo + ' - ' + e.emp_pnombre + ' ' + e.emp_snombre + ' ' + e.emp_papellido + ' ' + e.emp_sapellido Display FROM Empleados e WHERE e.emp_ffincontrato IS NULL AND e.empr_codigo = " & EmpresaActual)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateViewColumns()
        'Vista.PopulateColumns()
        FormatoGrid(Vista)

        Vista.Columns("Display").Visible = False
        Vista.Columns("Codigo").BestFit()
        Vista.Columns("Nombre").BestFit()

        Vista.OptionsBehavior.Editable = False
        Vista.OptionsView.ShowAutoFilterRow = True
    End Sub

    Public Sub GetCajaBanco(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        Dim Cat As New SysContab.VB.SysContab.CatalogoDB

        cb.Properties.DataSource = Cat.CatalogoList("A", 1).Tables("CATALOGO")
        cb.Properties.ValueMember = "Cuenta"
        cb.Properties.DisplayMember = "Nombre2"
        cb.Properties.PopulateColumns()

        cb.Properties.Columns("Nombre2").Visible = False
        cb.Properties.Columns("Orden").Visible = False

        cb.Properties.ShowHeader = False
        cb.Properties.ShowFooter = False
        cb.ItemIndex = 0
    End Sub

    Public Sub GetServicios_Retencion(ByVal cb As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
        cb.DataSource = ObtieneDatos("SELECT gi.CODIGO_GRUPO Codigo,gi.CODIGO_GRUPO + ' - ' + gi.NOMBRE Nombre" _
                                     + " FROM GRUPOS_INVENTARIO gi WHERE gi.TIPO = 'S' AND gi.NIVEL = 3 AND gi.EMPRESA = " & EmpresaActual)

        cb.ValueMember = "Codigo"
        cb.DisplayMember = "Nombre"
        cb.PopulateColumns()
        cb.Columns("Codigo").Visible = False
    End Sub

    'Public Function VerifyLiqOption() As Boolean
    '    Dim Liq As Boolean
    '    Liq = ObtieneDatos("SELECT Liquidacion FROM Configuraciones WHERE Empresa =" & EmpresaActual).Rows(0).Item(0)
    '    Return Liq
    'End Function

    Public Sub XtraMsg(ByVal msg As String, Optional ByVal Icono As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
                        Optional ByVal Tipo As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK, _
                        Optional ByVal Titulo As String = "")

        XtraMessageBox.Show(msg, IIf(Titulo = "", My.Application.Info.ProductName.ToString, Titulo), Tipo, Icono)
    End Sub

    Public Function XtraMsg2(ByVal msg As String, Optional ByVal Icono As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Question, _
                                Optional ByVal Tipo As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.YesNo, _
                                Optional ByVal Titulo As String = "") As Boolean

        If XtraMessageBox.Show(msg, IIf(Titulo = "", My.Application.Info.ProductName.ToString, Titulo), Tipo, Icono, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub GetCajasxUsuario(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        cb.Properties.DataSource = ObtieneDatos("sp_GetCajasxUsuario " & Usuario_ID & "," & EmpresaActual).DefaultView
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Caja"
        cb.Properties.PopulateColumns()
        cb.Properties.Columns(0).Visible = False
        cb.ItemIndex = 0
    End Sub

    Public Function ObtieneDataDS(ByVal StrSQL As String) As DataSet
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        Dim DA As New SqlDataAdapter(StrSQL, DC)
        Dim DS As New DataSet
        DA.Fill(DS, "Datos")
        Return DS
    End Function

    Public Sub GetTiposTrasladosCheck(ByVal cb As DevExpress.XtraEditors.CheckedComboBoxEdit)
        cb.Properties.DataSource = ObtieneDatos("JAR_GetTipoTraslados " & EmpresaActual)
        cb.Properties.ValueMember = "ID"
        cb.Properties.DisplayMember = "Nombre"
    End Sub

    Public Function GetTasaCambioDia(Fecha As Date) As Double
        Dim _DT As DataTable =
            ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & Fecha & "') Tasa")

        If _DT Is Nothing Then
            Return 1.0
        Else
            Return CDbl(_DT.Rows.Item(0)("Tasa"))
        End If
    End Function

    Public Sub GetClientesList(ByVal cb As DevExpress.XtraEditors.GridLookUpEdit, Optional Todos As Integer = 0)
        Dim Cliente As New VB.SysContab.ClientesDB
        cb.Properties.DataSource = Cliente.GetList(Todos).Tables("CLIENTES")
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateViewColumns()
        FormatoGrid(cb.Properties.View)
        ''
        cb.Properties.View.Columns("Cuenta").Visible = False
        cb.Properties.View.Columns("Contacto").Visible = False
        cb.Properties.View.Columns("Direccion").Visible = False
        cb.Properties.View.Columns("Telefono").Visible = False
        cb.Properties.View.Columns("Empresa").Visible = False
        cb.Properties.PopupFormSize = New Point(900, 0)

        cb.EditValue = 1
    End Sub

    Public Sub GetVendedores(ByVal cb As DevExpress.XtraEditors.LookUpEdit, Optional Todo As Integer = 0)
        Dim v As New VB.SysContab.VendedoresDB
        cb.Properties.DataSource = v.GetListBuscarCombo("%", Todo)
        cb.Properties.ValueMember = "Codigo"
        cb.Properties.DisplayMember = "Nombre"
        cb.Properties.PopulateColumns()
        cb.Properties.NullText = "[Seleccione]"

        For i As Integer = 0 To cb.Properties.Columns.Count - 1
            cb.Properties.Columns(i).Visible = False
        Next
        '
        cb.Properties.Columns("Nombre").Visible = True
        cb.Properties.SearchMode = Controls.SearchMode.AutoFilter
    End Sub

    Public Function GetVersion(ByVal ProductoVersion As String) As String
        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim ver As Version
            ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
            Return My.Application.Info.ProductName.ToString & ". Publicación v" & String.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision)
        Else
            Return My.Application.Info.ProductName.ToString & ". Publicación v" & ProductoVersion + "++"
            'Return My.Application.Info.ProductName.ToString & ". Versión sin Publicar"  ' & ProductoVersion
        End If
    End Function

    Function Conexion() As String
        Dim StrCnn As String = vbNullString
        Dim s As String() = LeeData()

        Server = s(0)
        DBName = s(1)

        'StrCnn = String.Format("Data Source={0}; Failover Partner = 192.168.0.6; Initial Catalog={1};User Id={2};Password={3};", s(0), s(1), s(2), s(3))

        StrCnn = String.Format("Data Source={0}; Initial Catalog={1};User Id={2};Password={3};", s(0), s(1), s(2), s(3))

        Return StrCnn
    End Function

    Sub EscribeData(ByVal Servidor As String, ByVal Base As String, _
                           ByVal Usuario_SQL As String, ByVal Password_SQL As String)
        'Region As String)

        Try
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NServer_RAMAC", Trim(Servidor))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NBase_RAMAC", Trim(Base))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NUsuario_RAMAC", Trim(Usuario_SQL))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NPassword_RAMAC", Trim(Password_SQL))
            'SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NRegion_RAMAC", Trim(Region))
        Catch ex As Exception
            XtraMsg("Error al Guardar en el registro de windows, favor consultar con el area de Soporte Tecnico." & vbCrLf & _
                    "Detalle del Error: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Function LeeData() As String()

        Dim Cadena(4) As String
        '
        Try
            ''SQL
            Cadena(0) = GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NServer_RAMAC")
            Cadena(1) = GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NBase_RAMAC")
            Cadena(2) = Login       'GetSetting(My.Application.Info.ProductName.ToString, "SysCadena", "NUsuario")
            Cadena(3) = Password    'GetSetting(My.Application.Info.ProductName.ToString, "SysCadena", "NPassword")
            'Cadena(4) = IIf(GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NRegion_RAMAC").ToString.Length = 0, _
            '                My.Application.Culture.Name, GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NRegion_RAMAC"))

            '' No se Encuentra la Confiuración, se agrega la configuracion registrada por defecto
            If Cadena(0).Trim.Length = 0 Then
                If Not File.Exists(Application.StartupPath & "\Configurar.ini") Then
                    If Not File.Exists(Application.StartupPath & "\Configurar.txt") Then
                        Cadena(0) = ""
                        Cadena(1) = ""
                        Cadena(2) = ""
                        Cadena(3) = ""
                    End If
                End If

                Dim ConnectionFile As System.IO.StreamReader
                Try
                    ConnectionFile = New System.IO.StreamReader(Application.StartupPath & "\Configurar.ini")
                Catch ex As Exception
                    ConnectionFile = New System.IO.StreamReader(Application.StartupPath & "\Configurar.txt")
                End Try

                Server = ConnectionFile.ReadLine.ToString()
                DBName = ConnectionFile.ReadLine.ToString()
                ContabilizarVenta = ConnectionFile.ReadLine.ToString()

                Cadena(0) = Server
                Cadena(1) = DBName
                Cadena(2) = Login
                Cadena(3) = Password
                Cadena(4) = My.Application.Culture.Name

                EscribeData(Server, DBName, Login, Password)
                'EscribeData(Server, DBName, Login, Password, My.Application.Culture.Name)
            End If
        Catch ex As Exception
            Cadena(0) = ""
            Cadena(1) = ""
            Cadena(2) = ""
            Cadena(3) = ""
        End Try

        Return Cadena
    End Function

    Sub EscribeEstilo(ByVal Valor As String)
        Try
            SaveSetting(My.Application.Info.ProductName.ToString, "Skin", "NSkin", Valor)
        Catch ex As Exception
            XtraMsg("Error al Guardar en el registro de windows, favor consultar con el area de Soporte Tecnico." & vbCrLf & _
                    "Detalle del Error: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Function LeeEstilo() As String
        Try
            Dim sk As String = GetSetting(My.Application.Info.ProductName.ToString, "Skin", "NSkin")

            ''No se Encuentra la Confiuración
            If sk.Trim.Length = 0 Then
                EscribeEstilo("DevExpress Style")
                Return "DevExpress Style"
            Else
                Return sk
            End If
        Catch ex As Exception
            Return "DevExpress Style"
        End Try
    End Function

    Sub ShowSplash(Optional ByVal sTitulo As String = "")
        Try
            If sTitulo <> "" Then WaitTitulo = sTitulo
            If sTitulo = "" Then WaitTitulo = "Cargando..."
            SplashScreenManager.ShowForm(GetType(WaitForm))
        Catch ex As Exception
        End Try
    End Sub

    Sub HideSplash()
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception
        End Try
    End Sub

    'Sub CierreDeDia()
    '    Try
    '        CierreDia = CDate(ObtieneDatos("SELECT MAX(Fecha) FROM CierreDia WHERE Empresa = " & EmpresaActual).Rows(0).Item(0))
    '    Catch ex As Exception
    '        CierreDia = vbNullString
    '        'GuardaDatos("sp_CierreAdd " & EmpresaActual)
    '        'GoTo Verificar
    '    End Try
    'End Sub

    Function Excel(Archivo As String, Hoja As String, Consulta As String) As DataTable

        Dim Conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Archivo & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
        Dim da As New OleDbDataAdapter(String.Format(Consulta, "[" & Hoja & "]"), Conn)
        Dim dtExcel As New DataTable
        da.Fill(dtExcel)

        Return dtExcel
    End Function

    Function Fields(Tipo As String) As DataTable
        Return ObtieneDatos("SELECT Valor as Fields, '' as AsignColumn, Required, '' Sample, DataType as Type FROM fields WHERE tipo ='" & Tipo & "'")
    End Function

    Sub CargarLogo()
        Try
            Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
            Dim data As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
            Dim ms As New MemoryStream(data)
            frmPrincipalRibbon.pLogo.Image = Image.FromStream(ms)
        Catch ex As Exception
        End Try
    End Sub

    Sub SavedImage(Tipo As String, _
                   Codigo As String)

        Dim SaveImage As Boolean = False
        Dim curFileName As String = ""
        Dim Extension As String = ""
        Dim Fichero As String = ""

        Dim cnnCatClientes As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

        Try
            'buscamos la imagen a grabar
            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "Archivos (IMAGENES, WORD, EXEL, POWER POINT, PDF) |*.jpg;*.png;*.gif;*.bmp;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pdf"
            Dim filter As String = openDlg.Filter
            openDlg.Title = "Seleccionar Documentos"
            If (openDlg.ShowDialog() = DialogResult.OK) Then
                curFileName = openDlg.FileName
                SaveImage = True

                Dim Info As New System.IO.FileInfo(openDlg.FileName)
                Extension = Info.Extension
                Fichero = openDlg.SafeFileName
            Else
                Exit Sub
            End If
            If SaveImage = True Then
                'CARGAR FOTOGRAFIA
                Dim fsFoto As FileStream
                fsFoto = New FileStream(curFileName, FileMode.Open)
                Dim fiFoto As FileInfo = New FileInfo(curFileName)
                Dim Temp As Long = fiFoto.Length
                Dim lung As Long = Convert.ToInt32(Temp)
                Dim picture(lung) As Byte
                fsFoto.Read(picture, 0, lung)
                fsFoto.Close()

                Dim cmdFoto As New System.Data.SqlClient.SqlCommand("sp_SoporteImagen", cnnCatClientes)
                cmdFoto.CommandType = CommandType.StoredProcedure

                Dim sql_ID_Cliente = New System.Data.SqlClient.SqlParameter("@Tipo", Tipo)
                Dim sql_ID_Documento = New System.Data.SqlClient.SqlParameter("@Codigo", Codigo)
                Dim sql_ID_Empresa = New System.Data.SqlClient.SqlParameter("@Empresa", EmpresaActual)
                Dim sql_FOTO As New System.Data.SqlClient.SqlParameter("@IMAGEN", SqlDbType.Image)
                Dim sql_Ext = New System.Data.SqlClient.SqlParameter("@Extension", Extension)
                Dim sql_Fichero = New System.Data.SqlClient.SqlParameter("@Fichero", Fichero)


                sql_FOTO.Value = picture

                cmdFoto.Parameters.Add(sql_ID_Cliente)
                cmdFoto.Parameters.Add(sql_ID_Documento)
                cmdFoto.Parameters.Add(sql_ID_Empresa)
                cmdFoto.Parameters.Add(sql_FOTO)
                cmdFoto.Parameters.Add(sql_Ext)
                cmdFoto.Parameters.Add(sql_Fichero)

                cnnCatClientes.Open()
                cmdFoto.ExecuteNonQuery()
                cmdFoto.Dispose()
                cnnCatClientes.Close()

                sql_FOTO = Nothing
                picture = Nothing

                XtraMsg("Registrado Correctamente")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub SavePDF(Tipo As String, Codigo As String)

        Dim SaveImage As Boolean = False
        Dim curFileName As String = ""

        Dim cnnCatClientes As New System.Data.SqlClient.SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

        Try
            'buscamos la imagen a grabar
            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "Files PDF|*.pdf;"
            Dim filter As String = openDlg.Filter
            openDlg.Title = "Open PFD Format Files"
            If (openDlg.ShowDialog() = DialogResult.OK) Then
                'PdfViewer1.LoadDocument(openDlg.FileName)
                curFileName = openDlg.FileName
                SaveImage = True
            Else
                Exit Sub
            End If

            ''buscamos la imagen a grabar
            'Dim openDlg As OpenFileDialog = New OpenFileDialog()
            'openDlg.Filter = "Documentos Excel (93-2007)|*.xls;"
            'Dim filter As String = openDlg.Filter
            'openDlg.Title = "Abrir Documentos Excel (93-2007)"
            'If (openDlg.ShowDialog() = DialogResult.OK) Then
            '    curFileName = openDlg.FileName
            '    SaveImage = True
            'Else
            '    Exit Sub
            'End If

            If SaveImage = True Then

                'CARGAR FOTOGRAFIA
                Dim fsFoto As FileStream
                fsFoto = New FileStream(curFileName, FileMode.Open)
                Dim fiFoto As FileInfo = New FileInfo(curFileName)
                Dim Temp As Long = fiFoto.Length
                Dim lung As Long = Convert.ToInt32(Temp)
                Dim picture(lung) As Byte
                fsFoto.Read(picture, 0, lung)
                fsFoto.Close()

                Dim cmdFoto As New System.Data.SqlClient.SqlCommand("sp_SoporteImagen", cnnCatClientes)
                cmdFoto.CommandType = CommandType.StoredProcedure

                Dim sql_ID_Cliente = New System.Data.SqlClient.SqlParameter("@Tipo", Tipo)
                Dim sql_ID_Documento = New System.Data.SqlClient.SqlParameter("@Codigo", Codigo)
                Dim sql_ID_Empresa = New System.Data.SqlClient.SqlParameter("@Empresa", EmpresaActual)
                Dim sql_FOTO As New System.Data.SqlClient.SqlParameter("@IMAGEN", SqlDbType.Image)
                sql_FOTO.Value = picture

                cmdFoto.Parameters.Add(sql_ID_Cliente)
                cmdFoto.Parameters.Add(sql_ID_Documento)
                cmdFoto.Parameters.Add(sql_ID_Empresa)
                cmdFoto.Parameters.Add(sql_FOTO)

                cnnCatClientes.Open()
                cmdFoto.ExecuteNonQuery()
                cmdFoto.Dispose()
                cnnCatClientes.Close()


                sql_FOTO = Nothing
                picture = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    'para saber el primer dia del mes
    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    'para saber el ultimo dia del mes
    Function UltimoDiaDelMes(ByVal Fecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)

        ' Return ObtieneDatos("sp_Ultimo_dia_Mes", Fecha).Rows.Item(0)("Fecha")

    End Function

    Sub CerrarProceso()
        Dim Lista_Procesos() As Process
        Dim p As Process
        Dim ret As String = ""

        Try
            ' obtiene una colección con los procesos a partir del nombre  
            Lista_Procesos = Process.GetProcessesByName(My.Application.Info.ProductName.ToString)

            If Lista_Procesos.Length <> 0 Then
                For Each p In Lista_Procesos
                    'XtraMsg(CStr(p.MainWindowTitle))
                    p.Kill()
                Next
            End If

            '' recorre la colección  
            'For Each p In Lista_Procesos
            '    ret = ret & "Nombre: " & CStr(p.MainWindowTitle) & _
            '                    "  PID : " & CStr(p.Id) & vbNewLine
            'Next
            '' muestra las instancias  
        Catch ex As Exception
        End Try
    End Sub

    Sub CargarConfiguracionRegional(cb As DevExpress.XtraEditors.LookUpEdit)

        Dim c1 As New DataColumn("UI")
        c1.DataType = GetType(String)

        Dim c2 As New DataColumn("Culture")
        c2.DataType = GetType(String)

        Dim c3 As New DataColumn("Nombre")
        c3.DataType = GetType(String)

        Dim DT As New DataTable("Globalization")

        DT.Columns.Add(c1)
        DT.Columns.Add(c2)
        DT.Columns.Add(c3)


        Dim objDic As New Dictionary(Of String, String)()

        For Each ObjCultureInfo As System.Globalization.CultureInfo In System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures)
            Dim objRegionInfo As New System.Globalization.RegionInfo(ObjCultureInfo.Name)
            If Not objDic.ContainsKey(objRegionInfo.DisplayName) Then
                ' objDic.Add(objRegionInfo.DisplayName, objRegionInfo.TwoLetterISORegionName.ToLower())

                Dim dr As DataRow = DT.NewRow

                dr("UI") = objRegionInfo.TwoLetterISORegionName.ToLower()
                dr("Culture") = objRegionInfo.Name
                dr("Nombre") = objRegionInfo.ThreeLetterISORegionName + " (" + objRegionInfo.DisplayName + ")"

                DT.Rows.Add(dr)
            End If
        Next

        LookUp(cb, DT, "Nombre", "Culture", "[Seleccione Región]", 0)
        cb.EditValue = My.Application.Culture.Name
        cb.Properties.ShowHeader = False
    End Sub


    Public Function GuardarFirmaDigital(IdUsuario As Integer, Firma As Image) As Boolean

        Dim conn As New SqlConnection(Conexion())
        Dim cmd As New SqlCommand("sp_ins_UsuariosFirmas", conn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
        Dim _IdUsuario As New SqlParameter("@IdUsuario", SqlDbType.Int)
        Dim _Firma As New SqlParameter("@Firma", SqlDbType.VarBinary)

        _Empresa.Value = EmpresaActual
        _IdUsuario.Value = IdUsuario
        _Firma.Value = ImageBytes(Firma)

        cmd.Parameters.Add(_Empresa)
        cmd.Parameters.Add(_IdUsuario)
        cmd.Parameters.Add(_Firma)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub VistaPreviaDX(rpt As DevExpress.XtraReports.UI.XtraReport,
                             Source As DataTable,
                             Titulo As String,
                             Optional CerrarMDI As Boolean = False)

        Dim frmContenedor As New frmManejadorReporte
        '
        With frmContenedor
            .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            .DocumentViewer1.Zoom = 1.18
            rpt.DataSource = Source
            rpt.ShowPrintMarginsWarning = False
            rpt.CreateDocument()
            If frmMDIReporte.Created Then .MdiParent = frmMDIReporte
            .CerrarMDI = CerrarMDI
            .Show()
            .Text = Titulo
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Public Sub FormatoRibbonVB(rb As Ribbon.RibbonControl)

        For Each Pagina As Ribbon.RibbonPage In rb.Pages
            For Each Grupo As Ribbon.RibbonPageGroup In Pagina.Groups

                For i As Integer = 0 To Grupo.ItemLinks.Count - 1

                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Normal.Font = New Font("Tahoma", 9, FontStyle.Bold)

                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Hovered.BackColor = Color.Red
                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Hovered.ForeColor = Color.White
                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Hovered.Font = New Font("Tahoma", 9, FontStyle.Bold)

                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Pressed.BackColor = Color.Red
                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Pressed.ForeColor = Color.White
                    Grupo.ItemLinks.Item(i).Item.ItemAppearance.Pressed.Font = New Font("Tahoma", 9, FontStyle.Bold)

                Next
            Next
        Next

    End Sub

    Public Sub ShowTCambio(TCambio As Double)
        frmPrincipalRibbon.bTCambio.Caption = "Tasa de Cambio del Dia: " & TCambio.ToString("n4")
    End Sub

End Module
