Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Module fn

    Public Sub XtraMsg(ByVal msg As String, Optional ByVal Icono As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information,
                       Optional ByVal Tipo As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.OK,
                       Optional ByVal Titulo As String = "")

        XtraMessageBox.Show(msg, IIf(Titulo = "", My.Application.Info.ProductName.ToString, Titulo), Tipo, Icono)
    End Sub

    Public Function XtraMsg2(ByVal msg As String, Optional ByVal Icono As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Question,
                                Optional ByVal Tipo As System.Windows.Forms.MessageBoxButtons = MessageBoxButtons.YesNo,
                                Optional ByVal Titulo As String = "") As Boolean

        If XtraMessageBox.Show(msg, IIf(Titulo = "", My.Application.Info.ProductName.ToString, Titulo), Tipo, Icono, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Conexion() As String
        Dim StrCnn As String = vbNullString
        Dim s As String() = LeeData()

        StrCnn = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", s(0), s(1), s(2), s(3))

        Return StrCnn
    End Function

    Function LeeData() As String()

        Dim Cadena(4) As String
        '
        Try
            ''SQL
            Cadena(0) = GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NServer_RAMAC")
            Cadena(1) = GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NBase_RAMAC")
            Cadena(2) = LoginN
            Cadena(3) = PasswordN
        Catch ex As Exception
            Cadena(0) = ""
            Cadena(1) = ""
            Cadena(2) = ""
            Cadena(3) = ""
        End Try

        Return Cadena
    End Function

    Function ObtieneDatos(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataTable

        Dim cn As New SqlConnection(Conexion())
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

    Function ObtieneDatosTN(ByVal Procedimiento As String, TableName As String, ByVal ParamArray Parametros() As Object) As DataTable

        Dim cn As New SqlConnection(Conexion())
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

    Function Guardar(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Boolean
        Try
            Dim cn As New SqlConnection(Conexion())
            Dim cmd As New SqlCommand

            cmd.CommandText = Procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            cn.Open()
            cmd.Connection = cn
            SqlCommandBuilder.DeriveParameters(cmd)
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If
            cmd.ExecuteNonQuery()
            cmd = Nothing
            cn.Close()

            Return True
        Catch ex As Exception
            XtraMsg("SP: " & Procedimiento & vbCrLf & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function IsNull(ByVal Var, Optional ByVal Valor = vbNullString)
        If IsDBNull(Var) OrElse IsNothing(Var) OrElse Var = vbNullString OrElse Var = Nothing Then
            Return IIf(IsNothing(Valor), "", Valor)
        Else
            Return Var
        End If
    End Function


    'Private Function ArmarXML(ByVal Parametro As Integer, DT_MAESTRO As DataTable, DT_DETALLE As DataTable) As String

    '    Dim PrimerCentro As Boolean
    '    Dim strXml As String
    '    Dim Contador As Integer
    '    Dim items As Integer
    '    Dim i As Integer
    '    Dim d As Integer
    '    Dim Cabecera As String
    '    Dim icontador As Integer
    '    icontador = 0
    '    Contador = 1
    '    items = 1
    '    strXml = ""
    '    Cabecera = ""

    '    ''Validaciones
    '    ''ESTOS CARACTERES SIEMPRE HAY QUE REEMPLAZARLOS
    '    'txtcliente.Text = Replace(txtcliente.Text, "'", "&apos;")
    '    'txtcliente.Text = Replace(txtcliente.Text, Chr(34), "&quot")
    '    'txtcliente.Text = Replace(txtcliente.Text, ">", "&gt;")
    '    'txtcliente.Text = Replace(txtcliente.Text, "<", "&lt;")
    '    'txtcliente.Text = Replace(txtcliente.Text, "&", "&amp;")

    '    'For i = 0 To ListView1.Items.Count - 1
    '    '    For d = 0 To 1
    '    '        ListView1.Items(i).SubItems(d).Text =
    '    '        Replace(ListView1.Items(i).SubItems(d).Text, "'", "&apos;")
    '    '        ListView1.Items(i).SubItems(d).Text =
    '    '        Replace(ListView1.Items(i).SubItems(d).Text, Chr(34), "&quot")
    '    '        ListView1.Items(i).SubItems(d).Text =
    '    '        Replace(ListView1.Items(i).SubItems(d).Text, ">", "&gt;")
    '    '        ListView1.Items(i).SubItems(d).Text =
    '    '        Replace(ListView1.Items(i).SubItems(d).Text, "<", "&lt;")
    '    '        ListView1.Items(i).SubItems(d).Text =
    '    '        Replace(ListView1.Items(i).SubItems(d).Text, "&", "&amp;")
    '    '    Next d
    '    'Next i
    '    Select Case Parametro
    '        Case 1
    '            ' Texto sin codificacion ISO,
    '            ' reemplazamos los caracteres alfabeticos comunes invalidos
    '            ' Recorro todos la cabecera para reemplazar los caracteres inválidos"

    '            Cabecera = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & "?>"

    '            'txtcliente.Text = Replace(txtcliente.Text, "ñ", "&#241;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "á", "&#224;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "é", "&#233;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "í", "&#237;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "ó", "&#243;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "ú", "&#250;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "Á", "&#193;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "É", "&#201;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "Í", "&#205;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "Ó", "&#211;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "Ú", "&#218;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "Ñ", "&#209;")
    '            'txtcliente.Text = Replace(txtcliente.Text, "¿", "&#191;")


    '            ' Recorro todos los items del listview para reemplazar los caracteres inválidos"

    '            'For i = 0 To ListView1.Items.Count - 1
    '            '    For d = 0 To 1
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "ñ",
    '            '                "&#241;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "á",
    '            '                "&#224;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "é",
    '            '                "&#233;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "í",
    '            '                "&#237;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "ó",
    '            '                "&#243;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "ú",
    '            '                "&#250;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "Á",
    '            '                "&#193;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "É",
    '            '                "&#201;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "Í",
    '            '                "&#205;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "Ó",
    '            '                "&#211;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "Ú",
    '            '                "&#218;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "Ñ",
    '            '                "&#209;")
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "¿",
    '            '                "&#191;")
    '            '        ' agregando " encoding="iso-8859-1" al XML
    '            '        ' se resuelve lo de arriba pero quedan caracteres "
    '            '        'que(pueden) traesr problemas como el de diametro "Ø"
    '            '        ListView1.Items(i).SubItems(d).Text =
    '            '            Replace(ListView1.Items(i).SubItems(d).Text, "Ø",
    '            '                "&#216;")

    '            '    Next d
    '            'Next i

    '        Case 2
    '            ' Similar al  anterior pero reemplazamos los caracteres > a 127 por su codigo 

    '            'For icontador = 128 To 255
    '            '    txtcliente.Text = Replace(txtcliente.Text, Chr(icontador), "&#" _
    '            '        & icontador.ToString & ";")
    '            '    ListView1.Items(i).SubItems(d).Text =
    '            '        Replace(ListView1.Items(i).SubItems(d).Text,
    '            '        Chr(icontador), "&#" & icontador.ToString & ";")
    '            'Next

    '            Cabecera = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & "?>"

    '        Case 3 ' No reemplazamos ningun caracter
    '            Cabecera = "<?xml version=" & Chr(34) & "1.0" & Chr(34) _
    '            & " encoding=" & Chr(34) & "iso-8859-1" & Chr(34) & "?>"

    '        Case 4 ' Reemplazamos algun caracter que la codificacion ISO no acepte (me ha pasado)
    '            Cabecera = "<?xml version=" & Chr(34) & "1.0" & Chr(34) _
    '            & " encoding=" & Chr(34) & "iso-8859-1" & Chr(34) & "?>"

    '            '    ListView1.Items(i).SubItems(d).Text =
    '            'Replace(ListView1.Items(i).SubItems(d).Text, "Ø",
    '            '    "&#216;")
    '            '    txtcliente.Text = Replace(txtcliente.Text, "Ø",
    '            '        "&#216;")

    '    End Select
    '    'Todos los items del listview tienen reemplazados los caracteres reservados
    '    ' y aquellos que XML no entiende
    '    'Procedemos a armar el XML

    '    'Cabecera observerse que para representar las "(comillas)
    '    ' utilizamos el codigo ascii Chr(34)"
    '    strXml = strXml & "<Pedido Cliente=" & Chr(34) & txtcliente.Text _
    '    & Chr(34) & " Numero=" & Chr(34) _
    '    & txtPedido.Text & Chr(34) & " Fecha=" & Chr(34) & dtpPEdido.Value.Month.ToString & "/" _
    '    & dtpPEdido.Value.Day.ToString & "/" & dtpPEdido.Value.Year.ToString & Chr(34) & ">"

    '    'N detalles
    '    For i = 0 To ListView1.Items.Count - 1
    '        strXml = strXml & "<ItemPedido Articulo=" & Chr(34) _
    '        & ListView1.Items(i).SubItems(0).Text & Chr(34) & " Cantidad=" & Chr(34) _
    '        & ListView1.Items(i).SubItems(1).Text & Chr(34) & "/> "
    '        items = items + 1
    '    Next


    '    ArmarXML = Cabecera & "<ROOT>" _
    '    & strXml _
    '    & " </Pedido></ROOT>"

    'End Function

End Module

