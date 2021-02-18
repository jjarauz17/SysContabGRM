Public Class db_DeslizamientoMoneda

    Public Property Mantenimiento_Valor As Double = 0.00
    Public Property Interes As Double = 0.00


    Public Sub CalcularDeslizamiento(Pago As Double, Tc1 As Double, Tc2 As Double, Optional EsAnticipo As Integer = 0)

        Dim _DT As DataTable =
            ObtieneDatos("sp_CalcularDeslizamientoMoneda",
                         Pago,
                         Tc1,
                         Tc2,
                         EsAnticipo)

        Mantenimiento_Valor = _DT.Rows.Item(0)("Mantenimiento")

    End Sub

    Public Sub CalcularInteres(Saldo As Double, Factura As String, Fecha As Date)

        Interes = ObtieneDatos("sp_sel_CalcularInteres",
                               Saldo,
                               Factura,
                               Fecha,
                               EmpresaA).
                               Rows.Item(0)("Interes")

    End Sub

End Class
