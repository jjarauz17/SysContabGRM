Imports DevExpress.XtraWizard
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
'Imports System.AppDomain.CurrentDomain.BaseDirectory

Public Class FrmNewBusiness

    Private Event FinishClick As WizardCommandButtonClickEventHandler

    Private Sub WizardPage2_PageValidating(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage2.PageValidating
        If DxValidationProvider1.Validate = False Then
            e.ErrorText = "Complete la informacion para continuar"
            e.Valid = False
        End If
        ''
        If chkImportar.Checked Then
            If cbEmpresas.EditValue Is Nothing Then
                XtraMsg("Seleccione la Empresa de la que desea importar los datos")
                e.Valid = False
            End If
        End If        
    End Sub

    Private Sub CompletionWizardPage1_PageCommit(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompletionWizardPage1.PageCommit
        'Dim Empresas As New VB.SysContab.EmpresasDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()
        Dim IdEmpresa As Integer = 0

        Try
            Dim Cont As Integer
            If Not Espacio.Checked Then Cont = 0 Else Cont = 1

            '' INICIAR TRANSACCION ******************************************************
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            ''***************************************************************************

            IdEmpresa = VB.SysContab.EmpresasDB.AddItem(Nombre.Text, "", "", "",
            "", IIf(Mes.Text = "ENERO", 1, 7), Año.Text, Now.Date,
            IsNull(Mayor.Text, 0), IIf(IsNull(SC01.Text, 0) > 0,
            IsNull(SC01.Text, 0) + (1 * Cont), IsNull(SC01.Text, 0)),
            IIf(IsNull(SC02.Text, 0) > 0, IsNull(SC02.Text, 0) + (2 * Cont), IsNull(SC02.Text, 0)),
            IIf(IsNull(SC03.Text, 0) > 0, IsNull(SC03.Text, 0) + (3 * Cont), IsNull(SC03.Text, 0)),
            IIf(IsNull(SC04.Text, 0) > 0, IsNull(SC04.Text, 0) + (4 * Cont), IsNull(SC04.Text, 0)),
            IIf(IsNull(SC05.Text, 0) > 0, IsNull(SC05.Text, 0) + (5 * Cont), IsNull(SC05.Text, 0)),
            IIf(IsNull(SC06.Text, 0) > 0, IsNull(SC06.Text, 0) + (6 * Cont), IsNull(SC06.Text, 0)),
            IIf(IsNull(SC07.Text, 0) > 0, IsNull(SC07.Text, 0) + (7 * Cont), IsNull(SC07.Text, 0)),
            IIf(IsNull(SC08.Text, 0) > 0, IsNull(SC08.Text, 0) + (8 * Cont), IsNull(SC08.Text, 0)),
            IIf(IsNull(SC09.Text, 0) > 0, IsNull(SC09.Text, 0) + (9 * Cont), IsNull(SC09.Text, 0)),
            "01", "01", 15, 2, 10, 1, 1000, 2, 0, 5, 1, False, 5, 1, 1, 1, 1, 1, 1, 1, Espacio.Checked,
            "001", -6, 0, 2, False) ', "graphics\logo.jpg")

            ' IdEmpresa = ObtieneDatosTrans("SELECT MAX(e.CODIGO) Codigo FROM EMPRESAS e").Rows(0).Item(0)
            'Agrega la moneda
            If Not GuardaDatosTrans("INSERT INTO Monedas (empr_codigo, mon_codigo, mon_descripcion, mon_simbolo, Buro) VALUES(" & IdEmpresa & ",'01','" & Moneda.Text & "','" & Simbolo.Text & "','')") Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            'Agrega la Bodega
            If Not GuardaDatosTrans("INSERT INTO Bodegas(Empresa,Ubicacion,Codigo_Bodega) VALUES(" & IdEmpresa & ",'" & Bodega.Text & "','001')") Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            'Agrega las configuraciones
            'ObtieneDatos("INSERT INTO Configuraciones(Empresa) VALUES(" & IdEmpresa & ")")

            'Agrega el permiso a la empresa
            If Not GuardaDatosTrans("INSERT INTO UsuariosEmpresas(User_id,Empresa_Id) VALUES (" & Usuario_ID & "," & IdEmpresa & ")") Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            'Agrega un concepto
            If Not GuardaDatosTrans("INSERT INTO Conceptos(Nombre,Empresa) VALUES ('Concepto'," & IdEmpresa & ")") Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            ''Agregar Fecha en Tabla de Cierre de Dia
            If Not GuardaDatosTrans("SET DATEFORMAT dmy; INSERT INTO CierreDia (Fecha, Empresa) VALUES ('01/01/2000'," & IdEmpresa & ")") Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            ''Insertar Clases de Movimientos
            If Not GuardaDatos("INSERT INTO TipoMovimientos_Clases SELECT Codigo_Clase, Nombre_Clasae," & IdEmpresa & " FROM dbo.TipoMovimientos_Clases tmc WHERE Empresa = " & IIf(EmpresaActual Is Nothing, 0, EmpresaActual)) Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            ''Insertar Datos de los departamentos
            If Not GuardaDatosTrans("INSERT INTO dbo.DEPARTAMENTOSC SELECT Codigo_Departamento, Nombre_Departamento, " & IdEmpresa & "  FROM DEPARTAMENTOSC d WHERE d.Empresa = " & IIf(EmpresaActual Is Nothing, 0, EmpresaActual)) Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            ''Insertar Centro de Costo
            If Not GuardaDatosTrans("INSERT INTO dbo.CentroDeCosto (Nombre,CuentaContable,Activo,Empresa) VALUES('" & Nombre.Text & "','',1," & IdEmpresa & ")") Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            'Agrega el Periodo
            Dim Desde As DateTime
            Dim Hasta As DateTime

            If Mes.Text = "ENERO" Then
                Desde = CDate(Format(CDate("01/01/" & CInt(Año.Text)), "dd/MM/yyyy"))
                Hasta = CDate(Format(CDate("31/12/" & CInt(Año.Text)), "dd/MM/yyyy"))
            Else
                Desde = CDate(Format(CDate("01/07/" & CInt(Año.Text)), "dd/MM/yyyy"))
                Hasta = CDate(Format(CDate("30/06/" & CInt(Año.Text) + 1), "dd/MM/yyyy"))
            End If

            Dim EmpresaActual_Temp As Integer = IIf(EmpresaActual Is Nothing, 0, EmpresaActual)
            EmpresaActual = IdEmpresa

            PeriodosDB.AddItem(Desde, Hasta, "PERIODO " & Año.Text, 1, 1)

            EmpresaActual = EmpresaActual_Temp

            '' Importar Datos de Otra Empresa
            If chkImportar.Checked Then
                For i As Integer = 0 To vDatos.DataRowCount - 1
                    If vDatos.GetRowCellValue(i, "Seleccionar") Then
                        If Not GuardaDatosTrans("JAR_ImportarDatosEmpresa " & IdEmpresa & "," & cbEmpresas.EditValue & "," & vDatos.GetRowCellValue(i, "Orden")) Then
                            VB.SysContab.Rutinas.ErrorTransaccion()
                            Exit Sub
                        End If
                    End If
                Next
            End If
            '' Fin de la Transaccion
            VB.SysContab.Rutinas.okTransaccion()
            ''/////////////////////////////////////////////////////////////////////////////////////////

            Try
                Kill(Application.StartupPath & "\graphics\logo.jpg")
                Logo.Image.Save(Application.StartupPath & "\graphics\logo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch ex As Exception
            End Try

            'MonedaBase = 1
            'Round = "n2"
            'RoundP = "n2"
            'NombreEmpresaActual = Nombre.Text
            'Dim lds As New DataSet
            'lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
            'lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)

            XtraMsg("La Nueva Empresa se ha Creado y Configurado con Exito !!!")
        Catch ex As Exception
            XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
            VB.SysContab.Rutinas.ErrorTransaccion()
            Exit Sub
        End Try

        ''Agrega el Periodo
        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction

        'Dim Desde As DateTime
        'Dim Hasta As DateTime

        'If Mes.Text = "ENERO" Then
        '    Desde = CDate(Format(CDate("01/01/" & CInt(Año.Text)), "dd/MM/yyyy"))
        '    Hasta = CDate(Format(CDate("31/12/" & CInt(Año.Text)), "dd/MM/yyyy"))
        'Else
        '    Desde = CDate(Format(CDate("01/07/" & CInt(Año.Text)), "dd/MM/yyyy"))
        '    Hasta = CDate(Format(CDate("30/06/" & CInt(Año.Text) + 1), "dd/MM/yyyy"))
        'End If

        'Try
        '    PeriodosDB.AddItem(Desde, Hasta, "", 1, 1)
        '    VB.SysContab.Rutinas.okTransaccion()
        'Catch ex As Exception
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    MsgBox(ex.Message)
        'End Try

        'Try
        '    Kill(Application.StartupPath & "\graphics\logo.jpg")
        '    Logo.Image.Save(Application.StartupPath & "\graphics\logo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        'Catch ex As Exception

        'End Try

        'MonedaBase = 1
        'Round = "n2"
        'RoundP = "n2"
        'NombreEmpresaActual = Nombre.Text

        'Dim lds As New DataSet
        'lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        'lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)
    End Sub

    Private Sub FrmNewBusiness_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbEmpresas.Properties.DataSource = ObtieneDatos("SELECT e.CODIGO, e.NOMBRE FROM EMPRESAS e")
        cbEmpresas.Properties.ValueMember = "CODIGO"
        cbEmpresas.Properties.DisplayMember = "NOMBRE"
        cbEmpresas.Properties.PopulateColumns()

        ''cbEmpresas.Properties.Columns(0).Visible = False
        cbEmpresas.ItemIndex = 0
        ''
        dgDatos.DataSource = ObtieneDatos("JAR_TablasImportar")
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
        ''
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        ''
        vDatos.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        vDatos.Columns("Orden").Visible = False
        vDatos.BestFitColumns()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImportar.CheckedChanged
        If chkImportar.Checked Then
            lEmpresa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lEmpresa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub
End Class