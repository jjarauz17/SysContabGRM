
Imports System.Linq
Imports System.Xml.Serialization
Imports ClasesBLL
Imports Newtonsoft.Json

Public Class frmBolsaAdd
    Dim _DT As New DataTable("Reporte_Bolsa")
    Dim UltimoCierre As Date
    Public IdBolsa As Integer = 0
    Dim obj As New FACTURAS_BOLSA
    Dim db As New db_FACTURAS_BOLSA

    Private Sub frmBolsaAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IdBolsa = 0 Then
            UltimoCierre = db_FACTURAS_BOLSA.UltimoCierre().Date.AddDays(1).Date
            Fecha.Properties.MinValue = UltimoCierre.AddDays(1).Date
            Fecha.DateTime = UltimoDiaDelMes(UltimoCierre.AddDays(1).Date).Date

            Codigo.Text = db_FACTURAS_BOLSA.GetNumero()
        Else
            obj = db_FACTURAS_BOLSA.Detalles(IdBolsa)
            Fecha.DateTime = obj.Fecha_Llave
            mDescripcion.Text = obj.Descripcion
            Codigo.Text = obj.Codigo
            UltimoCierre = New DateTime(Fecha.DateTime.Year, Fecha.DateTime.Month, 1).Date
        End If
        '
        Cargar(UltimoCierre.Date,
               Fecha.DateTime.Date)

        iVista.PopulateColumns()
        FormatoGrid(iVista, 4)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ShowSplash("Generando Reporte...")

        Cargar(UltimoCierre.Date,
            Fecha.DateTime.Date)

        HideSplash()
    End Sub

    Sub Cargar(Desde As Date,
               Hasta As Date)

        _DT = db_FACTURAS_BOLSA.Reporte(
            Desde,
            Hasta,
            IdBolsa)

        iGrid.DataSource = _DT

        'Dim list = New List(Of String)()
        'list = (From r In _DT.AsEnumerable() Select r.Field(Of String)(0)).ToList()

        'For Each row As DataRow In _DT.Rows
        '    list.Add(New TRANSACCIONES)
        '    ListTrans.Add(New TRANSACCIONES(TIPOU = row.Item(0)))
        'Next row
        'Dim serializer As New XmlSerializer(TypeOf (list(Of TRANSACCIONES)),
        '                           New XmlRootAttribute("Branches"))
        'Dim xml As Object = JsonConvert.DeserializeObject(list)()
        'XtraMsg(list.Count.ToString)
        ' Dim list As List(Of DataRow) = _DT.AsEnumerable().ToList()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If iVista.DataRowCount = 0 Then
            XtraMsg("No hay detalle para guardar.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        obj.IdBolsa = IdBolsa
        obj.Codigo = IIf(IdBolsa = 0, db_FACTURAS_BOLSA.GetNumero(), Codigo.Text)
        obj.Fecha_Llave = Fecha.DateTime.Date
        obj.Descripcion = mDescripcion.Text

        ShowSplash()
        '
        If IdBolsa = 0 Then
            IdBolsa = db.Insertar(obj)

            obj.IdBolsa = IdBolsa
            obj.Desde = UltimoCierre.Date
            obj.Hasta = Fecha.DateTime.Date

            If db.InsertarDetalle(obj) Then
                HideSplash()
                XtraMsg("Datos guardados con éxito!")
                '
                ShowSplash()
                Cargar(UltimoCierre.Date, Fecha.DateTime.Date)
                HideSplash()
            End If
        Else
            db.Actualizar(obj)
            HideSplash()
            '
            If Not CBool(obj.Aplicado) Then

            End If
        End If
        '        


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        frmBolsaDetalle.Dispose()

        With frmBolsaDetalle
            .Show()
        End With

    End Sub
End Class