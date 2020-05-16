Public Class db_TasaCambio

    Public Property MonedaBase As String
    Public Property MonedaCambio As String
    Public Property TC_Oficial As Double = 1.0
    Public Property TC_Paralelo As Double = 1.0
    Public Property Validar_Tasa As Boolean = True
    Public Property MensajeMes As String = ""
    Public Property MensajeDia As String = ""


    Public Sub GetTasaCambio(Moneda As String, Fecha As Date)
        Dim _DT As DataTable = ObtieneDatos("sp_sel_TASA_CAMBIO", Moneda, Fecha, EmpresaA)

        If _DT.Rows.Count > 0 Then
            With _DT.Rows(0)
                ' MonedaBase = .Item("mon_codigo")
                ' MonedaCambio = .Item("mon_codigo2")
                TC_Oficial = .Item("TASA_CAMBIO")
                TC_Paralelo = .Item("TC_PARALELO")
                Validar_Tasa = .Item("Validar")
                MensajeMes = .Item("MensajeMes")
                MensajeDia = .Item("MensajeDia")
            End With
        End If
    End Sub

End Class
