Public Class Funciones

    Public Shared Function DecodeBase64ToXML(valor As String) As Xml.XmlDocument
        Dim myBase64ret As Byte() = Convert.FromBase64String(valor)
        Dim myStr As String = System.Text.Encoding.UTF8.GetString(myBase64ret)
        Dim xmlDoc As New Xml.XmlDocument()
        xmlDoc.LoadXml(myStr)
        Return xmlDoc
    End Function

    Public Shared Function DecodeBase64ToString(valor As String) As String
        Dim myBase64ret As Byte() = Convert.FromBase64String(valor)
        Dim myStr As String = System.Text.Encoding.UTF8.GetString(myBase64ret)
        Return myStr
    End Function

    Public Shared Function EncodeStrToBase64(valor As String) As String
        Dim myByte As Byte() = System.Text.Encoding.UTF8.GetBytes(valor)
        Dim myBase64 As String = Convert.ToBase64String(myByte)
        Return myBase64
    End Function

    Public Function CreaCodigoSeguridad(TipoComprobante As String, Localidad As String,
                                        CodigoPuntoVenta As String, Fecha As Date,
                                        NumeroFactura As String) As String

        ''Los parametros TipoComprobante, Localidad y CodigoPuntoVenta pueden modificarse por otros valores, siempre manteniendo la longitud
        ''Tipo Comprobante debe tener 2 caracteres máximo
        ''Localidad debe tener 3 caracteres máximo
        ''Punto de Venta debe de tener 5 caracteres máximo
        ''Fecha es un campo datetime, debe ser la fecha de la factura
        ''Numero Factura debe tener máximo 10 caracteres y debe ser el mismo parámetro que se usa en la funcion CreaNumeroSecuencia
        Try
            If TipoComprobante.Trim.Length > 2 Then Throw New Exception("Tipo Comprobante debe tener 2 caracteres")
            If Localidad.Trim.Length > 3 Then Throw New Exception("Localidad no debe de superar los 3 caracteres")
            If CodigoPuntoVenta.Trim.Length > 5 Then Throw New Exception("Codigo Punto Venta no debe de superar los 5 caracteres")
            If NumeroFactura.Trim.Length > 10 Then Throw New Exception("Numero Factura no de superar los 10 caracteres")

            ''Concatenamos los valores para poder calcular el valor con la fórmula más adelante.
            Dim concatenado As String = ""
            concatenado += TipoComprobante.PadLeft(2, "0")
            concatenado += Localidad.PadLeft(3, "0")
            concatenado += CodigoPuntoVenta.PadLeft(5, "0")
            concatenado += Fecha.ToString("yyyyMMddHHmmss")
            concatenado += NumeroFactura.PadLeft(10, "10")

            If concatenado.Length <> 34 Then Throw New Exception("El concatenado debe de ser de 34 caracteres para poder calcular el código de seguridad")

            Dim calculo As Integer = 0

            calculo += CInt(concatenado.Substring(0, 1)) * 3
            calculo += CInt(concatenado.Substring(1, 1)) * 2
            calculo += CInt(concatenado.Substring(2, 1)) * 9
            calculo += CInt(concatenado.Substring(3, 1)) * 8
            calculo += CInt(concatenado.Substring(4, 1)) * 7
            calculo += CInt(concatenado.Substring(5, 1)) * 6
            calculo += CInt(concatenado.Substring(6, 1)) * 5
            calculo += CInt(concatenado.Substring(7, 1)) * 4
            calculo += CInt(concatenado.Substring(8, 1)) * 3
            calculo += CInt(concatenado.Substring(9, 1)) * 2
            calculo += CInt(concatenado.Substring(10, 1)) * 9
            calculo += CInt(concatenado.Substring(11, 1)) * 8
            calculo += CInt(concatenado.Substring(12, 1)) * 7
            calculo += CInt(concatenado.Substring(13, 1)) * 6
            calculo += CInt(concatenado.Substring(14, 1)) * 5
            calculo += CInt(concatenado.Substring(15, 1)) * 4
            calculo += CInt(concatenado.Substring(16, 1)) * 3
            calculo += CInt(concatenado.Substring(17, 1)) * 2
            calculo += CInt(concatenado.Substring(18, 1)) * 9
            calculo += CInt(concatenado.Substring(19, 1)) * 8
            calculo += CInt(concatenado.Substring(20, 1)) * 7
            calculo += CInt(concatenado.Substring(21, 1)) * 6
            calculo += CInt(concatenado.Substring(22, 1)) * 5
            calculo += CInt(concatenado.Substring(23, 1)) * 4
            calculo += CInt(concatenado.Substring(24, 1)) * 3
            calculo += CInt(concatenado.Substring(25, 1)) * 2
            calculo += CInt(concatenado.Substring(26, 1)) * 9
            calculo += CInt(concatenado.Substring(27, 1)) * 8
            calculo += CInt(concatenado.Substring(28, 1)) * 7
            calculo += CInt(concatenado.Substring(29, 1)) * 6
            calculo += CInt(concatenado.Substring(30, 1)) * 5
            calculo += CInt(concatenado.Substring(31, 1)) * 4
            calculo += CInt(concatenado.Substring(32, 1)) * 3
            calculo += CInt(concatenado.Substring(33, 1)) * 2

            ''Después de calcular el valor, obtenemos el dígito verificador.
            Dim mDV As Integer = 0
            Dim digitoMod As Integer = 0

            digitoMod = calculo Mod 11

            If digitoMod = 0 Or digitoMod = 1 Then
                mDV = 0
            Else
                mDV = 11 - digitoMod
            End If

            ''Retornamos el valor compuesto del tipo de documento, el valor calculado y el digito verificador.
            ''Esto nos retorna un valor congruente y estandarizado.
            Return TipoComprobante.PadLeft(2, "0") & calculo.ToString.PadLeft(5, "0") & mDV.ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
