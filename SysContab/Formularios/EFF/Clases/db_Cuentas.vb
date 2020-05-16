
Imports System.Data.SqlClient

Public Class db_Cuentas
    Inherits ClComun
    Dim vCuentasTabla As New Cuentas
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property CuentasTabla() As Cuentas
        Get
            Return vCuentasTabla
        End Get
        Set(ByVal value As Cuentas)
            vCuentasTabla = value
        End Set
    End Property

    Public Shared Function Listar_Catalogo_Seleccionar(Clasificacion As String, Data As String) As Data.DataTable

        Return DAL.Cargar("sp_GetCuentasCatalogoSeleccionar", Clasificacion, Data)
    End Function

    Public Shared Function Listar_Catalogo_Seleccionar(Data) As Data.DataTable

        Return DAL.Cargar("sp_GetCuentasCatalogoSeleccionar", EmpresaActual, Data)
    End Function


  
End Class
