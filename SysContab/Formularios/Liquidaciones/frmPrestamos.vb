Imports Microsoft.VisualBasic.Financial
Public Class frmPrestamos

    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmPrestamos = Nothing

    Dim DT1, DT2, DT3, DTOtrosCargos As DataTable
    Dim denominator As Double
    Dim NewData As Boolean = True

    Public Shared Function Instance() As frmPrestamos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPrestamos
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

    Private Sub frmPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cBancos.Properties.DataSource = ObtieneDatos("SELECT Codigo,Nombre FROM Bancos WHERE Activo = 1 AND Empresa= " & EmpresaActual)
        cBancos.Properties.ValueMember = "Codigo"
        cBancos.Properties.DisplayMember = "Nombre"
        cBancos.Properties.Columns("Codigo").Visible = False

        LoadGVs()

        DT3 = ObtieneDatos("SELECT LoanID,1 as Mes,SaldoInicial,Amortizacion, Interes, 0.00 as Mensualidad FROM PrestamosDetalle WHERE LoanID = 0")
        GridControl2.DataSource = DT3
        cmdNuevo.Focus()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If cmdNuevo.Text = "&Nuevo" Then
            cmdNuevo.Text = "&Guardar"
            cmdSalir.Text = "&Cancelar"
            gbData.Visible = True
            GridControl1.Visible = False
            GridControl2.Visible = True
            GridControl2.Location = New Point(12, 125)
            GridControl2.Height = 520
            cBancos.Focus()
        Else
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
            Conn.IniciarTransaccion()
            Dim LoanIDBack As Integer
            Try

                Conn.AddParameter("LoanID", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                Conn.AddParameter("BankID", SqlDbType.Int, 3, ParameterDirection.Input, cBancos.EditValue)
                Conn.AddParameter("LoanNo", SqlDbType.NChar, 10, ParameterDirection.Input, tbDocNo.Text)
                Conn.AddParameter("Amount", SqlDbType.Money, 10, ParameterDirection.Input, CDbl(tbSaldoInicial.Text))
                Conn.AddParameter("Rate", SqlDbType.Float, 4, ParameterDirection.Input, CDbl(tbInteres.Text))
                Conn.AddParameter("StartDate", SqlDbType.DateTime, 20, ParameterDirection.Input, dtInicio.DateTime)
                Conn.AddParameter("EndDate", SqlDbType.DateTime, 20, ParameterDirection.Input, dtFin.DateTime)
                Conn.AddParameter("Liq", SqlDbType.Bit, 1, ParameterDirection.Input, ckLiquidar.Checked)
                Conn.AddParameter("LiqType", SqlDbType.Int, 1, ParameterDirection.Input, cbTipoLiq.SelectedItem)
                Conn.AddParameter("LiqID", SqlDbType.Int, 5, ParameterDirection.Input, cbLiquidaciones.EditValue)
                Conn.AddParameter("Nuevo", SqlDbType.Bit, 1, ParameterDirection.Input, NewData)
                Conn.AddParameter("EmpresaID", SqlDbType.Int, 2, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("LoanIDBack", SqlDbType.Int, 2, ParameterDirection.Output, 0)

                Conn.EjecutarComando("SPJPrestamo")
                LoanIDBack = IsNull(Conn.GetParameter("LoanIDBack").Valor, 0)

                For i As Integer = 0 To GridView2.DataRowCount - 1
                    Conn.Clear()
                    Conn.AddParameter("LoanID", SqlDbType.Int, 3, ParameterDirection.Input, LoanIDBack)
                    Conn.AddParameter("SaldoInicial", SqlDbType.Money, 9, ParameterDirection.Input, GridView2.GetRowCellValue(i, "SaldoInicial"))
                    Conn.AddParameter("Amortizacion", SqlDbType.Money, 9, ParameterDirection.Input, GridView2.GetRowCellValue(i, "Amortizacion"))
                    Conn.AddParameter("Interes", SqlDbType.Money, 9, ParameterDirection.Input, GridView2.GetRowCellValue(i, "Interes"))
                    Conn.AddParameter("Nuevo", SqlDbType.Bit, 1, ParameterDirection.Input, NewData)

                    Conn.EjecutarComando("SPJPrestamoDetalle")
                Next

                'For j As Integer = 0 To DTOtrosCargos.Rows.Count - 1
                '    Conn.Clear()
                '    Conn.AddParameter("LiqID", SqlDbType.Int, 3, ParameterDirection.Input, LoanIDBack)
                '    Conn.AddParameter("LiqGastoID", SqlDbType.Int, 4, ParameterDirection.Input, DTOtrosCargos.Rows(j).Item(1))
                '    Conn.AddParameter("GastoMonto", SqlDbType.SmallMoney, 10, ParameterDirection.Input, DTOtrosCargos.Rows(j).Item(2))
                '    Conn.AddParameter("IB", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
                '    Conn.EjecutarComando("SPJPrestamoOtrosCargos")
                'Next

                Conn.CompletarTransaccion()
                cmdSalir_Click(Nothing, Nothing)
                LoadGVs()
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical)
                Conn.AnularTransaccion()
            End Try
        End If
        
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&Salir" And GridControl2.Visible = True Then
            GridControl2.Visible = False
            GridControl1.Height = 520
        ElseIf cmdSalir.Text = "&Salir" Then
            Me.Close()
        Else
            cmdNuevo.Text = "&Nuevo"
            cmdSalir.Text = "&Salir"
            gbData.Visible = False
            GridControl1.Visible = True : GridControl2.Visible = False
            DT2.Rows.Clear()
            GridView2.RefreshData()
        End If
    End Sub

    Private Sub cmdCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCalc.Click
        If CDbl(tbSaldoInicial.Text) = 0.0 Or CInt(tbMeses.Text) = 0 Then
            MsgBox("Favor llenar uno de los siguientes campo: préstamo o tasa de interés.", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            If GridView2.RowCount > 0 Then
                GridView2.SelectAll()
                GridView2.DeleteSelectedRows()
            End If
            DT3.Clear()
            Dim Valor As Decimal = 0, Valor0 As Decimal = 0
            For i As Integer = 0 To Me.tbMeses.EditValue - 1
                Dim fila As DataRow : fila = DT3.NewRow()
                fila.Item("LoanID") = i + 1
                fila.Item("Mes") = i + 1
                fila.Item("SaldoInicial") = Math.Round(IIf(i = 0, CDbl(tbSaldoInicial.Text), Valor0) - Valor, 2)
                Valor0 = Math.Round(IIf(i = 0, CDbl(tbSaldoInicial.Text), Valor0) - Valor, 2)
                If i <> Me.tbMeses.EditValue - 1 Then
                    fila.Item("Amortizacion") = Math.Round(Financial.PPmt(Math.Round(((tbInteres.Text) / 100) / 12, 2), i + 1, Me.tbMeses.EditValue, tbSaldoInicial.EditValue, 0), 2) * -1
                Else
                    fila.Item("Amortizacion") = Valor0
                End If

                Valor = Math.Round(Financial.PPmt(Math.Round((CDbl(tbInteres.Text) / 100) / 12, 2), i + 1, Me.tbMeses.EditValue, tbSaldoInicial.EditValue, 0), 2) * -1
                fila.Item("Interes") = Math.Round(Financial.IPmt(Math.Round((CDbl(tbInteres.Text) / 100) / 12, 2), i + 1, Me.tbMeses.EditValue, tbSaldoInicial.EditValue, 0), 2) * -1
                fila.Item("Mensualidad") = Math.Round(Financial.Pmt(Math.Round((CDbl(tbInteres.Text) / 100) / 12, 2), Me.tbMeses.EditValue, tbSaldoInicial.EditValue, 0), 2) * -1
                DT3.Rows.Add(fila)
            Next
            GridView2.RefreshData()
        End If
    End Sub

    Private Sub ckLiquidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckLiquidar.CheckedChanged
        If ckLiquidar.Checked = True Then
            Label20.Visible = True : Label23.Visible = True
            cbTipoLiq.Visible = True : cbLiquidaciones.Visible = True
        Else
            Label20.Visible = False : Label23.Visible = False
            cbTipoLiq.Visible = False : cbLiquidaciones.Visible = False
        End If
    End Sub

    Private Sub dtInicio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtInicio.EditValueChanged, dtFin.EditValueChanged
        tbMeses.Text = DateDiff(DateInterval.Month, dtInicio.DateTime.Date, dtFin.DateTime.Date)
    End Sub

    Private Sub cbTipoLiq_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoLiq.EditValueChanged
        If cbTipoLiq.SelectedIndex = 0 Then
            cbLiquidaciones.Properties.DataSource = ObtieneDatos("SELECT MTID,MTNo, 0 as LiqID FROM Liquidaciones_MercaderiaTransito WHERE InBond = 0")
        ElseIf cbTipoLiq.SelectedIndex = 1 Then
            cbLiquidaciones.Properties.DataSource = ObtieneDatos("SELECT MTID,MTNo, LiqIBID as LiqID FROM Liquidaciones_MercaderiaTransito WHERE InBond = 1")
        Else
            cbLiquidaciones.Properties.DataSource = ObtieneDatos("SELECT MTID,MTNo lmt.LiqIBID as LiqID FROM Liquidaciones_MercaderiaTransito lmt " & _
                                                 "JOIN LiquidacionesIB li ON lmt.LiqIBID = li.LiqIBID JOIN liquidaciones l ON li.LiqIBID = l.LiqIBID" & _
                                                 "  AND li.EmpresaID = l.EmpresaID WHERE l.EmpresaID =" & EmpresaActual)
        End If
        cbLiquidaciones.Properties.ValueMember = "MTID"
        cbLiquidaciones.Properties.DisplayMember = "MtNo"
        cbLiquidaciones.Properties.PopulateColumns()
    End Sub

    Private Sub LoadGVs()
        Dim DS As New DataSet

        DT1 = ObtieneDatos("SELECT LoanID,b.NOMBRE,LoanNo,p.LoanAmount,p.InterestRate AS Interes,p.StarDate AS FechaInicio, p.EndDate AS FechaFin " & _
   "FROM Prestamos p JOIN BANCOS b ON p.BankID = b.CODIGO WHERE p.EmpresaID =" & EmpresaActual)
        DT2 = ObtieneDatos("SELECT LoanID,1 as Mes, SaldoInicial,Amortizacion,Interes, 0.00 as Mensualidad, Contabilizado FROM PrestamosDetalle")
        For i As Integer = 0 To DT2.Rows.Count - 1
            DT2.Rows(i).Item("Mensualidad") = DT2.Rows(i).Item("Amortizacion") + DT2.Rows(i).Item("Interes")
        Next
        GridControl2.DataSource = DT2

        DS.Tables.Add(DT1) : DS.Tables(0).TableName = "Loan"
        DS.Tables.Add(DT2) : DS.Tables(1).TableName = "LoanDetail"

        Try
            DS.Tables(0).Columns("LoanID").DefaultValue = 0
            DS.Tables(1).Columns("LoanID").DefaultValue = 0
            DS.Tables(0).Columns("LoanID").AllowDBNull = False
            DS.Tables(1).Columns("LoanID").AllowDBNull = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DS.Relations.Add("LoansRel", DS.Tables("Loan").Columns("LoanID"), DS.Tables("LoanDetail").Columns("LoanID"))

        GridControl1.DataSource = DS.Tables(0) : GridView1.PopulateColumns()
        GridView1.Columns(0).Visible = False
    End Sub

    'Private Sub LoadGV2(ByVal LoanID As Integer)
    '    DT3 = ObtieneDatos("SELECT LoanID,1 as Mes, 0.00 as SaldoInicial,0.00 as Amortizacion, 0.00 as Interes, 0.00 as Mensualidad FROM PrestamosDetalle WHERE LoanID = " & LoanID)
    '    GridControl2.DataSource = DT3
    'End Sub

    'Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
    '    GridControl1.Height = 20
    '    LoadGV2(GridView1.GetFocusedRowCellValue("LoanID"))
    '    GridControl2.Visible = True
    '    GridControl2.Location = New Point(12, 145)
    '    GridControl2.Height = 500
    'End Sub

    Private Sub cmdOtherCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOtherCharges.Click
        Dim f As frmOtrosCargos = f.Instance
        f.GastoTipo = 1
        f.ShowDialog()
        tbOtrosCargos.EditValue = f.x
        DTOtrosCargos = f.dt
        f.WindowState = FormWindowState.Normal

    End Sub

End Class