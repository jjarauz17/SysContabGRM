Public Class db_DeslizamientoMoneda

    Public Property Mantenimiento_Valor As Double = 0

    Public Sub CalcularDeslizamiento(Pago As Double, Tc1 As Double, Tc2 As Double, Optional EsAnticipo As Integer = 0)

        Dim _DT As DataTable = ObtieneDatos("sp_CalcularDeslizamientoMoneda", Pago, Tc1, Tc2, EsAnticipo)

        Mantenimiento_Valor = _DT.Rows.Item(0)("Mantenimiento")

    End Sub

End Class
