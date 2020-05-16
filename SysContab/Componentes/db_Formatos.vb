Imports System.IO
Public Class db_Formatos

    Public Shared Function FormatoImpreso(Tipo As Integer, Repx As String) As Boolean

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("sp_sel_Formatos",
                                      Tipo,
                                      EmpresaActual) _
                                      .Rows(0).Item(0), Byte())

            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\" & Repx & ".repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
