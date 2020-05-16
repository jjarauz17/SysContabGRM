Imports DbConnect

Public Class db_Esquemas

    '' Private Conn As Connect
    '' Private Cadena As String = cl_CadenaConexion.CadenaConexion

    Public Shared Sub Guardar(Control As String,
                                   Descripcion As String,
                                   XmlFile As String,
                                   Inicial As Integer)
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        ''
        ''Dim Arch As New IO.FileInfo(My.Application.Info.DirectoryPath & "\XML\xml_" & RolesDetalles.Rows(i)("Nombre") & ".xml")
        Dim Arch As New IO.FileInfo(XmlFile)

        If IO.File.Exists(Arch.FullName) Then
            Conn.RemoveParameters()
            Conn.AddParameter("Control", SqlDbType.NVarChar, 50, ParameterDirection.Input, Control)
            Conn.AddParameter("Descripcion", SqlDbType.NVarChar, 512, ParameterDirection.Input, Descripcion)
            Conn.AddParameter("Data", SqlDbType.VarBinary, 0, ParameterDirection.Input, XMLToDBFile(Arch.FullName))
            Conn.AddParameter("Inicial", SqlDbType.Int, 4, ParameterDirection.Input, Inicial)
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)

            Conn.EjecutarComando("sp_guardar_esquema")
        End If
    End Sub

    Public Shared Sub GuardarInicial(Control As String,
                                   Descripcion As String,
                                   XmlFile As String)

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        ''
        Dim Arch As New IO.FileInfo(XmlFile)

        If IO.File.Exists(Arch.FullName) Then
            Conn.RemoveParameters()
            Conn.AddParameter("Control", SqlDbType.NVarChar, 50, ParameterDirection.Input, Control)
            Conn.AddParameter("Descripcion", SqlDbType.NVarChar, 512, ParameterDirection.Input, Descripcion)
            Conn.AddParameter("Data", SqlDbType.VarBinary, 0, ParameterDirection.Input, XMLToDBFile(Arch.FullName))
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)

            Conn.EjecutarComando("sp_guardar_esquema_inicial")
        End If

    End Sub


    Public Shared Sub Borrar(Control As String,
                                  Inicial As Integer)

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        ''
        Conn.RemoveParameters()
        Conn.AddParameter("Control", SqlDbType.NVarChar, 50, ParameterDirection.Input, Control)
        Conn.AddParameter("Inicial", SqlDbType.Int, 4, ParameterDirection.Input, Inicial)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)

        Conn.EjecutarComando("sp_borrar_esquema")
    End Sub


    'Public Function ValidarEsquema() As Boolean

    'End Function

    Public Shared Function GetEsquema(Control As String, Inicial As Integer) As DataTable
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

        Try
            Conn.RemoveParameters()
            Conn.AddParameter("Control", SqlDbType.NVarChar, 50, ParameterDirection.Input, Control)
            Conn.AddParameter("Inicial", SqlDbType.Int, 4, ParameterDirection.Input, Inicial)
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)

            Return Conn.EjecutarComando("sp_sel_esquema")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

End Class
