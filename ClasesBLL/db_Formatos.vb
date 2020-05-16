Public Class db_Formatos

    Public Shared Function GetFormato(Tipo As Integer) As DataTable

        Return ObtieneDatos("sp_get_formato_imprimir", Tipo, EmpresaA)

    End Function




End Class
