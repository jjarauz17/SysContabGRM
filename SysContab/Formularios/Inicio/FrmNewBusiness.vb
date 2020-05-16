Imports DevExpress.XtraWizard
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports System.AppDomain.CurrentDomain.BaseDirectory

Public Class FrmNewBusiness

    Private Event FinishClick As WizardCommandButtonClickEventHandler

    Private Sub WizardPage2_PageValidating(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage2.PageValidating
        If DxValidationProvider1.Validate = False Then
            e.ErrorText = "Complete la informacion para continuar"
            e.Valid = False
        End If
    End Sub

    Private Sub CompletionWizardPage1_PageCommit(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompletionWizardPage1.PageCommit
        Dim Empresas As New VB.SysContab.EmpresasDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()

        Try
            Dim Cont As Integer
            If Not Espacio.Checked Then Cont = 0 Else Cont = 1

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            Empresas.AddItem(Nombre.Text, "", "", "", _
            "", IIf(Mes.Text = "ENERO", 1, 7), Año.Text, Now.Date, _
            IsNull(Mayor.Text, 0), IIf(IsNull(SC01.Text, 0) > 0, _
            IsNull(SC01.Text, 0) + (1 * Cont), IsNull(SC01.Text, 0)), _
            IIf(IsNull(SC02.Text, 0) > 0, IsNull(SC02.Text, 0) + (2 * Cont), IsNull(SC02.Text, 0)), _
            IIf(IsNull(SC03.Text, 0) > 0, IsNull(SC03.Text, 0) + (3 * Cont), IsNull(SC03.Text, 0)), _
            IIf(IsNull(SC04.Text, 0) > 0, IsNull(SC04.Text, 0) + (4 * Cont), IsNull(SC04.Text, 0)), _
            IIf(IsNull(SC05.Text, 0) > 0, IsNull(SC05.Text, 0) + (5 * Cont), IsNull(SC05.Text, 0)), _
            IIf(IsNull(SC06.Text, 0) > 0, IsNull(SC06.Text, 0) + (6 * Cont), IsNull(SC06.Text, 0)), _
            IIf(IsNull(SC07.Text, 0) > 0, IsNull(SC07.Text, 0) + (7 * Cont), IsNull(SC07.Text, 0)), _
            IIf(IsNull(SC08.Text, 0) > 0, IsNull(SC08.Text, 0) + (8 * Cont), IsNull(SC08.Text, 0)), _
            IIf(IsNull(SC09.Text, 0) > 0, IsNull(SC09.Text, 0) + (9 * Cont), IsNull(SC09.Text, 0)), _
            1, 1, 15, 2, 10, 1, 1000, 2, 0, 5, 1, False, 5, 1, 1, 1, 1, 1, 1, 1, Espacio.Checked, _
            1, -6, 0, 2, False) ', "graphics\logo.jpg")

            VB.SysContab.Rutinas.okTransaccion()

            EmpresaActual = ObtieneDatos("SELECT Codigo FROM Empresas").Rows(0).Item(0)
            'Agrega la moneda
            ObtieneDatos("INSERT INTO Monedas VALUES(" & EmpresaActual & ",1,'" & Moneda.Text & "','" & Simbolo.Text & "')")

            'Agrega la Bodega
            ObtieneDatos("INSERT INTO Bodegas(Empresa,Ubicacion,Codigo_Bodega) VALUES(" & EmpresaActual & ",'" & Bodega.Text & "','" & Codigo.Text & "')")

            'Agrega las configuraciones
            'ObtieneDatos("INSERT INTO Configuraciones(Empresa) VALUES(" & EmpresaActual & ")")

            'Agrega el permiso a la empresa
            ObtieneDatos("INSERT INTO UsuariosEmpresas(User_id,Empresa_Id) VALUES (" & Usuario_ID & "," & EmpresaActual & ")")

            'Agrega un concepto
            ObtieneDatos("INSERT INTO Conceptos(Nombre,Empresa) VALUES ('Concepto'," & EmpresaActual & ")")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try

        'Agrega el Periodo
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        Dim Desde As DateTime
        Dim Hasta As DateTime

        If Mes.Text = "ENERO" Then
            Desde = CDate(Format(CDate("01/01/" & CInt(Año.Text)), "dd/MM/yyyy"))
            Hasta = CDate(Format(CDate("31/12/" & CInt(Año.Text)), "dd/MM/yyyy"))
        Else
            Desde = CDate(Format(CDate("01/07/" & CInt(Año.Text)), "dd/MM/yyyy"))
            Hasta = CDate(Format(CDate("30/06/" & CInt(Año.Text) + 1), "dd/MM/yyyy"))
        End If

        Try
            PeriodosDB.AddItem(Desde, Hasta, "", 1, 1)
            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message)
        End Try

        Try
            Kill(Application.StartupPath & "\graphics\logo.jpg")
            Logo.Image.Save(Application.StartupPath & "\graphics\logo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception

        End Try

        MonedaBase = 1
        Round = "n2"
        RoundP = "n2"
        NombreEmpresaActual = Nombre.Text

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)
    End Sub
End Class