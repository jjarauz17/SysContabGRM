Public Class FacturaXML

    Public Property ClaveNumerica As String = "0"
    Public Property Consecutivo As String = "0"
    Public Property Estado As String
    Public Property Mensaje As String
    Public Property XmlSinFimra As Object
    Public Property XmlFirmado As Object
    Public Property XmlRespuesta As Object
    Public Property Token As String

    Public Sub Detalle(Factura As String, Tipo As String)

        Dim _dt As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS_XML",
                                            Factura,
                                            EmpresaA,
                                            Tipo)

        If _dt.Rows.Count > 0 Then
            With _dt.Rows(0)
                ClaveNumerica = .Item("ClaveNumerica")
                Consecutivo = .Item("Consecutivo")
                Estado = .Item("Estado")
                Mensaje = .Item("MensajeHacienda")
                XmlSinFimra = .Item("FacturaXML")
                XmlFirmado = .Item("XmlFirmado")
                XmlRespuesta = .Item("XmlRespuesta")
                Token = .Item("Token")
            End With
        End If
    End Sub

End Class
