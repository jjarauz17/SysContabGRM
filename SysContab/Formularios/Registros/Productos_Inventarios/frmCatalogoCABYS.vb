Imports System.Data.OleDb
Imports System.IO

Public Class frmCatalogoCABYS

    Public ok As Boolean = False

    Private vCodigo As String,
        vImpuesto As Double,
        Archivo As String,
        Hoja As String

    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal value As String)
            vCodigo = value
        End Set
    End Property

    Public Property Impuesto() As Double
        Get
            Return vImpuesto
        End Get
        Set(ByVal value As Double)
            vImpuesto = value
        End Set
    End Property

    Public Sub Main(_DT As DataTable)

        'If Not File.Exists(Application.StartupPath & "\CABYS.xls") Then
        '    XtraMsg("Falta el archivo CABYS.xml que contiene el Catalog de Códigos de bienes y servicio de Hacienda", MessageBoxIcon.Error)
        '    ok = False
        '    '
        '    Dispose()
        '    'Return String.Empty
        'End If

        ShowSplash("Cargando Catalogo...")

        'Archivo = Application.StartupPath & "\CABYS.xls"
        'Hoja = "Hoja1$"

        'Dim dtExcel As New DataTable
        'dtExcel = Excel(Archivo, Hoja, "select * from {0}")
        ' iGrid.DataSource = dtExcel

        iGrid.DataSource = _DT
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 0)

        HideSplash()

        Me.ShowDialog()
        Me.Dispose()
    End Sub

    Private Sub frmCatalogoCABYS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        Seleccionar()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Seleccionar()
    End Sub

    Sub Seleccionar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro  de la lista!")
            Exit Sub
        End If
        '
        Codigo = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Código del bien o servicio")

        Dim iva As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Impuesto")

        If iva.Equals("Exento") Then
            Impuesto = 0.00
        Else
            iva = iva.Replace("%", "")
            Impuesto = iva
        End If
        '
        ok = True
        Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        With New frmExportarImprimir
            .Mostrar(iGrid, Me.Text)
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ok = False
        Close()
    End Sub

    Private Sub frmCatalogoCABYS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ok = False
            Close()
        End If
    End Sub
End Class