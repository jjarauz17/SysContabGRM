Imports System
Imports System.IO

Module ArchivosDB

    Sub SavedImage(Tipo As String, _
                  Codigo As String)

        Dim SaveImage As Boolean = False
        Dim curFileName As String = ""
        Dim Extension As String = ""
        Dim Fichero As String = ""

        Dim cnnCatClientes As New System.Data.SqlClient.SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

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

    Public Function GetDocumentos(Tipo As String, Codigo As String) As DataTable
        Return ObtieneDatos("sp_GetDocuementos", Tipo, Codigo, EmpresaActual)
    End Function

    Public Function GetImages(Id As Integer) As DataTable
        Return ObtieneDatos("sp_GetImagenesxID", Id)
    End Function

    Public Sub DeleteImage(Id As Integer)
        GuardaDatos("DELETE FROM Soportes WHERE IdSoporte =" & Id)
    End Sub

    Public Sub AbrirDocumento(Id As Integer, Fichero As String)

        Try
            Dim Data As Byte() = CType(VB.SysContab.ClientesDB.GetImages(Id).Rows(0).Item(0), Byte())

            Dim Tamano As Integer = Data.GetUpperBound(0)
            Dim Cadena As String = Application.StartupPath & "\" & IIf(Fichero.Trim.Length = 0, "Manual.pdf", Fichero)
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Process.Start(Cadena)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try


    End Sub

End Module
