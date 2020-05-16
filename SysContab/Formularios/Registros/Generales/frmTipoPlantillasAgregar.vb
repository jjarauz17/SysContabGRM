Public Class frmTipoPlantillasAgregar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmTipoPlantillasAgregar = Nothing

    Public Shared Function Instance() As frmTipoPlantillasAgregar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTipoPlantillasAgregar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEsquema As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbPagoProveedores As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIVANombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIVACuenta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIRCuenta As System.Windows.Forms.TextBox
    Friend WithEvents CbIRC As System.Windows.Forms.ComboBox
    Friend WithEvents CbIRVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbBanC As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbIVAC As System.Windows.Forms.ComboBox
    Friend WithEvents CbIVAVar As System.Windows.Forms.ComboBox
    Friend WithEvents CbProvVar As System.Windows.Forms.ComboBox
    Friend WithEvents CbProvC As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipoProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbBlank As System.Windows.Forms.GroupBox
    Friend WithEvents gbInstalacion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDepCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents cbDeptVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbDeptC As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cbBancosVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents cbBancoVarReco As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancoReco As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cbProvVarReco As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvReco As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtReco As System.Windows.Forms.TextBox
    Friend WithEvents cbRecoVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbRecoC As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbReconexion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCajaCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCaja As System.Windows.Forms.TextBox
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents cbCajaVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbCajaConcep As System.Windows.Forms.ComboBox
    Friend WithEvents gbxContado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cbVarIVAIngr As System.Windows.Forms.ComboBox
    Friend WithEvents cbConceptoIVAIngr As System.Windows.Forms.ComboBox
    Friend WithEvents txtIVACuentaIngr As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAIngr As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxCredito As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIVACred As System.Windows.Forms.TextBox
    Friend WithEvents txtIVACredNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaCred As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCred As System.Windows.Forms.TextBox
    Friend WithEvents gbxIVA As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIVAReper As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAReperNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIVASoport As System.Windows.Forms.TextBox
    Friend WithEvents txtIVASoportNombre As System.Windows.Forms.TextBox
    Friend WithEvents gbxIR As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIRPag As System.Windows.Forms.TextBox
    Friend WithEvents txtIRPagNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIRVent As System.Windows.Forms.TextBox
    Friend WithEvents txtIRVentNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIRPagServ As System.Windows.Forms.TextBox
    Friend WithEvents txtIRPagServNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCajaIR As System.Windows.Forms.TextBox
    Friend WithEvents txtCajaIRNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCajaIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtCajaIVANombre As System.Windows.Forms.TextBox
    Friend WithEvents Button17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIRContadoVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRContadoConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRContadoCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRContadoNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIRCatalogo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbIvaCreditoVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIvaCreditoConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents cbIngresoCreditoVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIngresoCreditoConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents gbReciboCaja As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox28 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCajaVariable1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCajaConcepto1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtCajaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCajaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button19 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMoneda1Cuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda1Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Button18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMoneda2Variable As System.Windows.Forms.ComboBox
    Friend WithEvents cbMoneda2Concepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtMoneda2Cuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda2Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Button20 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbMoneda1Variable As System.Windows.Forms.ComboBox
    Friend WithEvents cbMoneda1Concepto As System.Windows.Forms.ComboBox
    Friend WithEvents gbDepositoBancario As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button23 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox29 As System.Windows.Forms.GroupBox
    Friend WithEvents Button21 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents Button22 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbReciboIRVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbReciboIRConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtReciboIRCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtReciboIRNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbReciboIvaConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtReciboIvaCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtReciboIvaNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbReciboIvaVariable As System.Windows.Forms.ComboBox
    Friend WithEvents txtIngrCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIngrNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbIngrVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIngrConceptos As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCajaVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbCajaConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtCajaCuentaContado As System.Windows.Forms.TextBox
    Friend WithEvents txtCajaNombreContado As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents gbComprasContado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIRCCVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRCCConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRCCCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRCCNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button24 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox34 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIvaCCConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtIvaCCCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaCCNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button25 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbIvaCCVariable As System.Windows.Forms.ComboBox
    Friend WithEvents gbComprasCredito As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox36 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIvaCCredVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIvaCCredConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtIvaCCredCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaCCredNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button27 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbImpuestos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox35 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox37 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox38 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox39 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox31 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIRSRCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRSRNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIRResidentes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRxPCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRxPNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIRxPagar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRAnticipoCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRAnticipoNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIRAnticipo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRSPCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRSPNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIRSP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRSalarioCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIRSalarioNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIRSalario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox40 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIva2Codigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIva2Nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox41 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIva1Codigo As System.Windows.Forms.TextBox
    Friend WithEvents txtIva1Nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdIva2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIva1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox42 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCajaImpCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCajaImpNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdCajaImp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbNotaCredito As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox44 As System.Windows.Forms.GroupBox
    Friend WithEvents Button26 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox47 As System.Windows.Forms.GroupBox
    Friend WithEvents Button30 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNCCajaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNCCajaNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNCIvaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNCIvaNombre As System.Windows.Forms.TextBox
    Friend WithEvents gbNotaDebito As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox45 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNDCajaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNDCajaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button28 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox46 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNDIvaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNDIvaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button29 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox43 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox48 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button31 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox49 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button32 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox50 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button33 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox51 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button34 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox52 As System.Windows.Forms.GroupBox
    Friend WithEvents gbAlcaldia As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox54 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAlcaldiaCajaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtAlcaldiaCajaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button35 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox57 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAlcaldiaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtAlcaldiaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button38 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox58 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Button39 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox59 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Button40 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox60 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Button41 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox61 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents Button42 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox53 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostoVentaCuentaIngr As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoVentaNombreIngr As System.Windows.Forms.TextBox
    Friend WithEvents Button36 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox55 As System.Windows.Forms.GroupBox
    Friend WithEvents Button37 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbVarCostoVentaIngr As System.Windows.Forms.ComboBox
    Friend WithEvents cbConceptoCostoVentaIngr As System.Windows.Forms.ComboBox
    Friend WithEvents cbVarInventarioIngr As System.Windows.Forms.ComboBox
    Friend WithEvents cbInventarioVentaIngr As System.Windows.Forms.ComboBox
    Friend WithEvents txtInventarioCuentaIngr As System.Windows.Forms.TextBox
    Friend WithEvents txtInventarioNombreIngr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox56 As System.Windows.Forms.GroupBox
    Friend WithEvents Button43 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox62 As System.Windows.Forms.GroupBox
    Friend WithEvents Button44 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbIngresoCreditoCostoVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIngresoCreditoCostoConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuentaCostoCred As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCostoCred As System.Windows.Forms.TextBox
    Friend WithEvents cbInventarioConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtInventarioCred As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreInventarioCred As System.Windows.Forms.TextBox
    Friend WithEvents cbInventarioVariable As System.Windows.Forms.ComboBox
    Friend WithEvents gbMttoValor As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox64 As System.Windows.Forms.GroupBox
    Friend WithEvents Button45 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button46 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIngresoMtto As System.Windows.Forms.TextBox
    Friend WithEvents txtIngresoMttoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEgresoMttoNombre As System.Windows.Forms.TextBox
    Friend WithEvents gbexgreso As System.Windows.Forms.GroupBox
    Friend WithEvents txtEgresoMtto As System.Windows.Forms.TextBox
    Friend WithEvents gbPagoProductos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox65 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox66 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox67 As System.Windows.Forms.GroupBox
    Friend WithEvents Button47 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button48 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button49 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProdBancos As System.Windows.Forms.TextBox
    Friend WithEvents txtProdBancosNombre As System.Windows.Forms.TextBox
    Friend WithEvents cBancosProdVar As System.Windows.Forms.ComboBox
    Friend WithEvents cBancosProdC As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvProdVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvProdC As System.Windows.Forms.ComboBox
    Friend WithEvents txtProdProvCta As System.Windows.Forms.TextBox
    Friend WithEvents txtProdProvNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtProdIVACta As System.Windows.Forms.TextBox
    Friend WithEvents txtProdIVANombre As System.Windows.Forms.TextBox
    Friend WithEvents cbIVAProdVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbIVAProdC As System.Windows.Forms.ComboBox
    Friend WithEvents gbProveedoresServicios As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox68 As System.Windows.Forms.GroupBox
    Friend WithEvents Button50 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox69 As System.Windows.Forms.GroupBox
    Friend WithEvents Button51 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button52 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CBIRXPAGAR As System.Windows.Forms.ComboBox
    Friend WithEvents CBIRXPAGARVAR As System.Windows.Forms.ComboBox
    Friend WithEvents TXTIRXPAGARNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTIRXPAGARCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents CBPROVEEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents CBPROVEEDORVAR As System.Windows.Forms.ComboBox
    Friend WithEvents TXTPROVEEDORNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTPROVEEDORCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox71 As System.Windows.Forms.GroupBox
    Friend WithEvents CBGASTOSVAR As System.Windows.Forms.ComboBox
    Friend WithEvents CBGASTOS As System.Windows.Forms.ComboBox
    Friend WithEvents TXTGASTOSNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTGASTOSCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox63 As System.Windows.Forms.GroupBox
    Friend WithEvents Button53 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CBIVAPORCOBRAR As System.Windows.Forms.ComboBox
    Friend WithEvents CBIVAPORCOBRARVAR As System.Windows.Forms.ComboBox
    Friend WithEvents TXTIVAPORCOBRARNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTIVAXCOBRAR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox72 As System.Windows.Forms.GroupBox
    Friend WithEvents cbBancoP As System.Windows.Forms.ComboBox
    Friend WithEvents cbBancoPVar As System.Windows.Forms.ComboBox
    Friend WithEvents Button54 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBancoPNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtBancoP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox73 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIRP As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRPvar As System.Windows.Forms.ComboBox
    Friend WithEvents Button55 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRPNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIRP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox75 As System.Windows.Forms.GroupBox
    Friend WithEvents Button57 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProvPNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtProvP As System.Windows.Forms.TextBox
    Friend WithEvents cbProvPVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvP As System.Windows.Forms.ComboBox
    Friend WithEvents gbProveedorServiciosPagar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox70 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIRxPagarC As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRxPagarV As System.Windows.Forms.ComboBox
    Friend WithEvents Button56 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIRxPagarN As System.Windows.Forms.TextBox
    Friend WithEvents txtIRxPagarC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox74 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCompraCredVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompraCredConcep As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRCompraCredC As System.Windows.Forms.TextBox
    Friend WithEvents txtIRCompraCredN As System.Windows.Forms.TextBox
    Friend WithEvents Button58 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbccVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbccConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtccCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtccNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button59 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbCCBanco As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox76 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIRAlcVariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRAlcConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRAlcCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIRAlcNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button60 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox77 As System.Windows.Forms.GroupBox
    Friend WithEvents Button61 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbIRxPagAlcC As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRxPagAlcVar As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRPagoAlcNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIRPagoAlcCuenta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox78 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIRCompContVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRCompContConcep As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRCompContCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIRCompContNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button62 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox79 As System.Windows.Forms.GroupBox
    Friend WithEvents Button63 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbIRAlcCompCredVar As System.Windows.Forms.ComboBox
    Friend WithEvents cbIRAlcCompCredConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtIRAlcCompCredCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIRAlcCompCredNombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox80 As System.Windows.Forms.GroupBox
    Friend WithEvents cbdevolucionvariable As System.Windows.Forms.ComboBox
    Friend WithEvents cbdevolucionconcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtdevolucionnombre As System.Windows.Forms.TextBox
    Friend WithEvents Button64 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtdevolucioncuenta As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoPlantillasAgregar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid()
        Me.cbEsquema = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTipoComp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbTipoProv = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbPagoProveedores = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CbIRC = New System.Windows.Forms.ComboBox()
        Me.CbIRVar = New System.Windows.Forms.ComboBox()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIRNombre = New System.Windows.Forms.TextBox()
        Me.txtIRCuenta = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbIVAC = New System.Windows.Forms.ComboBox()
        Me.CbIVAVar = New System.Windows.Forms.ComboBox()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIVANombre = New System.Windows.Forms.TextBox()
        Me.txtIVACuenta = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbBanC = New System.Windows.Forms.ComboBox()
        Me.cbBancVar = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CbProvVar = New System.Windows.Forms.ComboBox()
        Me.CbProvC = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBlank = New System.Windows.Forms.GroupBox()
        Me.gbInstalacion = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cbBancosVar = New System.Windows.Forms.ComboBox()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtDepCuenta = New System.Windows.Forms.TextBox()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.cbDeptVar = New System.Windows.Forms.ComboBox()
        Me.cbDeptC = New System.Windows.Forms.ComboBox()
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cbBancoVarReco = New System.Windows.Forms.ComboBox()
        Me.cbBancoReco = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cbProvVarReco = New System.Windows.Forms.ComboBox()
        Me.cbProvReco = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtRecoCuenta = New System.Windows.Forms.TextBox()
        Me.txtReco = New System.Windows.Forms.TextBox()
        Me.cbRecoVar = New System.Windows.Forms.ComboBox()
        Me.cbRecoC = New System.Windows.Forms.ComboBox()
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbReconexion = New System.Windows.Forms.GroupBox()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.cbCajaVar = New System.Windows.Forms.ComboBox()
        Me.cbCajaConcep = New System.Windows.Forms.ComboBox()
        Me.txtCajaCuenta = New System.Windows.Forms.TextBox()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxContado = New System.Windows.Forms.GroupBox()
        Me.GroupBox76 = New System.Windows.Forms.GroupBox()
        Me.cbIRAlcVariable = New System.Windows.Forms.ComboBox()
        Me.cbIRAlcConcepto = New System.Windows.Forms.ComboBox()
        Me.txtIRAlcCuenta = New System.Windows.Forms.TextBox()
        Me.txtIRAlcNombre = New System.Windows.Forms.TextBox()
        Me.Button60 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox55 = New System.Windows.Forms.GroupBox()
        Me.cbVarInventarioIngr = New System.Windows.Forms.ComboBox()
        Me.cbInventarioVentaIngr = New System.Windows.Forms.ComboBox()
        Me.txtInventarioCuentaIngr = New System.Windows.Forms.TextBox()
        Me.txtInventarioNombreIngr = New System.Windows.Forms.TextBox()
        Me.Button37 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox53 = New System.Windows.Forms.GroupBox()
        Me.cbVarCostoVentaIngr = New System.Windows.Forms.ComboBox()
        Me.cbConceptoCostoVentaIngr = New System.Windows.Forms.ComboBox()
        Me.txtCostoVentaCuentaIngr = New System.Windows.Forms.TextBox()
        Me.txtCostoVentaNombreIngr = New System.Windows.Forms.TextBox()
        Me.Button36 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.cbIRContadoVariable = New System.Windows.Forms.ComboBox()
        Me.cbIRContadoConcepto = New System.Windows.Forms.ComboBox()
        Me.txtIRContadoCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRContadoNombre = New System.Windows.Forms.TextBox()
        Me.cmdIRCatalogo = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.cbVarIVAIngr = New System.Windows.Forms.ComboBox()
        Me.cbConceptoIVAIngr = New System.Windows.Forms.ComboBox()
        Me.txtIVACuentaIngr = New System.Windows.Forms.TextBox()
        Me.txtIVAIngr = New System.Windows.Forms.TextBox()
        Me.Button7 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txtIngrCuenta = New System.Windows.Forms.TextBox()
        Me.txtIngrNombre = New System.Windows.Forms.TextBox()
        Me.cbIngrVariable = New System.Windows.Forms.ComboBox()
        Me.cbIngrConceptos = New System.Windows.Forms.ComboBox()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.cbCajaVariable = New System.Windows.Forms.ComboBox()
        Me.cbCajaConcepto = New System.Windows.Forms.ComboBox()
        Me.txtCajaCuentaContado = New System.Windows.Forms.TextBox()
        Me.txtCajaNombreContado = New System.Windows.Forms.TextBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox80 = New System.Windows.Forms.GroupBox()
        Me.cbdevolucionvariable = New System.Windows.Forms.ComboBox()
        Me.cbdevolucionconcepto = New System.Windows.Forms.ComboBox()
        Me.txtdevolucioncuenta = New System.Windows.Forms.TextBox()
        Me.txtdevolucionnombre = New System.Windows.Forms.TextBox()
        Me.Button64 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxCredito = New System.Windows.Forms.GroupBox()
        Me.GroupBox56 = New System.Windows.Forms.GroupBox()
        Me.cbInventarioVariable = New System.Windows.Forms.ComboBox()
        Me.cbInventarioConcepto = New System.Windows.Forms.ComboBox()
        Me.txtInventarioCred = New System.Windows.Forms.TextBox()
        Me.txtNombreInventarioCred = New System.Windows.Forms.TextBox()
        Me.Button43 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox62 = New System.Windows.Forms.GroupBox()
        Me.cbIngresoCreditoCostoVariable = New System.Windows.Forms.ComboBox()
        Me.cbIngresoCreditoCostoConcepto = New System.Windows.Forms.ComboBox()
        Me.txtCuentaCostoCred = New System.Windows.Forms.TextBox()
        Me.txtNombreCostoCred = New System.Windows.Forms.TextBox()
        Me.Button44 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.txtIVACred = New System.Windows.Forms.TextBox()
        Me.txtIVACredNombre = New System.Windows.Forms.TextBox()
        Me.Button9 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbIvaCreditoVariable = New System.Windows.Forms.ComboBox()
        Me.cbIvaCreditoConcepto = New System.Windows.Forms.ComboBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.cbIngresoCreditoVariable = New System.Windows.Forms.ComboBox()
        Me.cbIngresoCreditoConcepto = New System.Windows.Forms.ComboBox()
        Me.txtCuentaCred = New System.Windows.Forms.TextBox()
        Me.txtNombreCred = New System.Windows.Forms.TextBox()
        Me.Button10 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxIVA = New System.Windows.Forms.GroupBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.txtCajaIVA = New System.Windows.Forms.TextBox()
        Me.txtCajaIVANombre = New System.Windows.Forms.TextBox()
        Me.Button17 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.txtIVAReper = New System.Windows.Forms.TextBox()
        Me.txtIVAReperNombre = New System.Windows.Forms.TextBox()
        Me.Button11 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.txtIVASoport = New System.Windows.Forms.TextBox()
        Me.txtIVASoportNombre = New System.Windows.Forms.TextBox()
        Me.Button12 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxIR = New System.Windows.Forms.GroupBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.txtCajaIR = New System.Windows.Forms.TextBox()
        Me.txtCajaIRNombre = New System.Windows.Forms.TextBox()
        Me.Button16 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.txtIRPagServ = New System.Windows.Forms.TextBox()
        Me.txtIRPagServNombre = New System.Windows.Forms.TextBox()
        Me.Button15 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.txtIRPag = New System.Windows.Forms.TextBox()
        Me.txtIRPagNombre = New System.Windows.Forms.TextBox()
        Me.Button13 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.txtIRVent = New System.Windows.Forms.TextBox()
        Me.txtIRVentNombre = New System.Windows.Forms.TextBox()
        Me.Button14 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox43 = New System.Windows.Forms.GroupBox()
        Me.GroupBox48 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button31 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox49 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button32 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox50 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button33 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox51 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button34 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbReciboCaja = New System.Windows.Forms.GroupBox()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.cbReciboIvaVariable = New System.Windows.Forms.ComboBox()
        Me.cbReciboIvaConcepto = New System.Windows.Forms.ComboBox()
        Me.txtReciboIvaCuenta = New System.Windows.Forms.TextBox()
        Me.txtReciboIvaNombre = New System.Windows.Forms.TextBox()
        Me.Button22 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.cbReciboIRVariable = New System.Windows.Forms.ComboBox()
        Me.cbReciboIRConcepto = New System.Windows.Forms.ComboBox()
        Me.txtReciboIRCuenta = New System.Windows.Forms.TextBox()
        Me.txtReciboIRNombre = New System.Windows.Forms.TextBox()
        Me.Button21 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.cbCajaVariable1 = New System.Windows.Forms.ComboBox()
        Me.cbCajaConcepto1 = New System.Windows.Forms.ComboBox()
        Me.txtCajaCodigo = New System.Windows.Forms.TextBox()
        Me.txtCajaNombre = New System.Windows.Forms.TextBox()
        Me.Button19 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.cbMoneda1Variable = New System.Windows.Forms.ComboBox()
        Me.cbMoneda1Concepto = New System.Windows.Forms.ComboBox()
        Me.txtMoneda1Cuenta = New System.Windows.Forms.TextBox()
        Me.txtMoneda1Nombre = New System.Windows.Forms.TextBox()
        Me.Button18 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.cbMoneda2Variable = New System.Windows.Forms.ComboBox()
        Me.cbMoneda2Concepto = New System.Windows.Forms.ComboBox()
        Me.txtMoneda2Cuenta = New System.Windows.Forms.TextBox()
        Me.txtMoneda2Nombre = New System.Windows.Forms.TextBox()
        Me.Button20 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbDepositoBancario = New System.Windows.Forms.GroupBox()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button23 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbComprasContado = New System.Windows.Forms.GroupBox()
        Me.GroupBox78 = New System.Windows.Forms.GroupBox()
        Me.cbIRCompContVar = New System.Windows.Forms.ComboBox()
        Me.cbIRCompContConcep = New System.Windows.Forms.ComboBox()
        Me.txtIRCompContCuenta = New System.Windows.Forms.TextBox()
        Me.txtIRCompContNombre = New System.Windows.Forms.TextBox()
        Me.Button62 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbCCBanco = New System.Windows.Forms.GroupBox()
        Me.cbccVariable = New System.Windows.Forms.ComboBox()
        Me.cbccConcepto = New System.Windows.Forms.ComboBox()
        Me.txtccCuenta = New System.Windows.Forms.TextBox()
        Me.txtccNombre = New System.Windows.Forms.TextBox()
        Me.Button59 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.cbIRCCVariable = New System.Windows.Forms.ComboBox()
        Me.cbIRCCConcepto = New System.Windows.Forms.ComboBox()
        Me.txtIRCCCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRCCNombre = New System.Windows.Forms.TextBox()
        Me.Button24 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.cbIvaCCVariable = New System.Windows.Forms.ComboBox()
        Me.cbIvaCCConcepto = New System.Windows.Forms.ComboBox()
        Me.txtIvaCCCodigo = New System.Windows.Forms.TextBox()
        Me.txtIvaCCNombre = New System.Windows.Forms.TextBox()
        Me.Button25 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbComprasCredito = New System.Windows.Forms.GroupBox()
        Me.GroupBox79 = New System.Windows.Forms.GroupBox()
        Me.cbIRAlcCompCredVar = New System.Windows.Forms.ComboBox()
        Me.cbIRAlcCompCredConcepto = New System.Windows.Forms.ComboBox()
        Me.txtIRAlcCompCredCuenta = New System.Windows.Forms.TextBox()
        Me.txtIRAlcCompCredNombre = New System.Windows.Forms.TextBox()
        Me.Button63 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox74 = New System.Windows.Forms.GroupBox()
        Me.cbCompraCredVar = New System.Windows.Forms.ComboBox()
        Me.cbCompraCredConcep = New System.Windows.Forms.ComboBox()
        Me.txtIRCompraCredC = New System.Windows.Forms.TextBox()
        Me.txtIRCompraCredN = New System.Windows.Forms.TextBox()
        Me.Button58 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox36 = New System.Windows.Forms.GroupBox()
        Me.cbIvaCCredVariable = New System.Windows.Forms.ComboBox()
        Me.cbIvaCCredConcepto = New System.Windows.Forms.ComboBox()
        Me.txtIvaCCredCodigo = New System.Windows.Forms.TextBox()
        Me.txtIvaCCredNombre = New System.Windows.Forms.TextBox()
        Me.Button27 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbImpuestos = New System.Windows.Forms.GroupBox()
        Me.GroupBox42 = New System.Windows.Forms.GroupBox()
        Me.txtCajaImpCodigo = New System.Windows.Forms.TextBox()
        Me.txtCajaImpNombre = New System.Windows.Forms.TextBox()
        Me.cmdCajaImp = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox40 = New System.Windows.Forms.GroupBox()
        Me.txtIva2Codigo = New System.Windows.Forms.TextBox()
        Me.txtIva2Nombre = New System.Windows.Forms.TextBox()
        Me.cmdIva2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox41 = New System.Windows.Forms.GroupBox()
        Me.txtIva1Codigo = New System.Windows.Forms.TextBox()
        Me.txtIva1Nombre = New System.Windows.Forms.TextBox()
        Me.cmdIva1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.txtIRSalarioCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRSalarioNombre = New System.Windows.Forms.TextBox()
        Me.cmdIRSalario = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.txtIRSRCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRSRNombre = New System.Windows.Forms.TextBox()
        Me.cmdIRResidentes = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox37 = New System.Windows.Forms.GroupBox()
        Me.txtIRxPCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRxPNombre = New System.Windows.Forms.TextBox()
        Me.cmdIRxPagar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.txtIRAnticipoCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRAnticipoNombre = New System.Windows.Forms.TextBox()
        Me.cmdIRAnticipo = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox39 = New System.Windows.Forms.GroupBox()
        Me.txtIRSPCodigo = New System.Windows.Forms.TextBox()
        Me.txtIRSPNombre = New System.Windows.Forms.TextBox()
        Me.cmdIRSP = New DevExpress.XtraEditors.SimpleButton()
        Me.gbNotaCredito = New System.Windows.Forms.GroupBox()
        Me.GroupBox44 = New System.Windows.Forms.GroupBox()
        Me.txtNCCajaCodigo = New System.Windows.Forms.TextBox()
        Me.txtNCCajaNombre = New System.Windows.Forms.TextBox()
        Me.Button26 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox47 = New System.Windows.Forms.GroupBox()
        Me.txtNCIvaCodigo = New System.Windows.Forms.TextBox()
        Me.txtNCIvaNombre = New System.Windows.Forms.TextBox()
        Me.Button30 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbNotaDebito = New System.Windows.Forms.GroupBox()
        Me.GroupBox45 = New System.Windows.Forms.GroupBox()
        Me.txtNDCajaCodigo = New System.Windows.Forms.TextBox()
        Me.txtNDCajaNombre = New System.Windows.Forms.TextBox()
        Me.Button28 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox46 = New System.Windows.Forms.GroupBox()
        Me.txtNDIvaCodigo = New System.Windows.Forms.TextBox()
        Me.txtNDIvaNombre = New System.Windows.Forms.TextBox()
        Me.Button29 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox52 = New System.Windows.Forms.GroupBox()
        Me.GroupBox58 = New System.Windows.Forms.GroupBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Button39 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox59 = New System.Windows.Forms.GroupBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Button40 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox60 = New System.Windows.Forms.GroupBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Button41 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox61 = New System.Windows.Forms.GroupBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Button42 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbAlcaldia = New System.Windows.Forms.GroupBox()
        Me.GroupBox54 = New System.Windows.Forms.GroupBox()
        Me.txtAlcaldiaCajaCodigo = New System.Windows.Forms.TextBox()
        Me.txtAlcaldiaCajaNombre = New System.Windows.Forms.TextBox()
        Me.Button35 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox57 = New System.Windows.Forms.GroupBox()
        Me.txtAlcaldiaCodigo = New System.Windows.Forms.TextBox()
        Me.txtAlcaldiaNombre = New System.Windows.Forms.TextBox()
        Me.Button38 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbMttoValor = New System.Windows.Forms.GroupBox()
        Me.GroupBox64 = New System.Windows.Forms.GroupBox()
        Me.txtIngresoMtto = New System.Windows.Forms.TextBox()
        Me.txtIngresoMttoNombre = New System.Windows.Forms.TextBox()
        Me.Button45 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbexgreso = New System.Windows.Forms.GroupBox()
        Me.txtEgresoMtto = New System.Windows.Forms.TextBox()
        Me.txtEgresoMttoNombre = New System.Windows.Forms.TextBox()
        Me.Button46 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbPagoProductos = New System.Windows.Forms.GroupBox()
        Me.GroupBox65 = New System.Windows.Forms.GroupBox()
        Me.txtProdBancos = New System.Windows.Forms.TextBox()
        Me.txtProdBancosNombre = New System.Windows.Forms.TextBox()
        Me.Button49 = New DevExpress.XtraEditors.SimpleButton()
        Me.cBancosProdVar = New System.Windows.Forms.ComboBox()
        Me.cBancosProdC = New System.Windows.Forms.ComboBox()
        Me.GroupBox66 = New System.Windows.Forms.GroupBox()
        Me.cbProvProdVar = New System.Windows.Forms.ComboBox()
        Me.cbProvProdC = New System.Windows.Forms.ComboBox()
        Me.Button48 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProdProvCta = New System.Windows.Forms.TextBox()
        Me.txtProdProvNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox67 = New System.Windows.Forms.GroupBox()
        Me.txtProdIVACta = New System.Windows.Forms.TextBox()
        Me.txtProdIVANombre = New System.Windows.Forms.TextBox()
        Me.cbIVAProdVar = New System.Windows.Forms.ComboBox()
        Me.cbIVAProdC = New System.Windows.Forms.ComboBox()
        Me.Button47 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbProveedoresServicios = New System.Windows.Forms.GroupBox()
        Me.GroupBox77 = New System.Windows.Forms.GroupBox()
        Me.cbIRxPagAlcC = New System.Windows.Forms.ComboBox()
        Me.cbIRxPagAlcVar = New System.Windows.Forms.ComboBox()
        Me.Button61 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIRPagoAlcNombre = New System.Windows.Forms.TextBox()
        Me.txtIRPagoAlcCuenta = New System.Windows.Forms.TextBox()
        Me.GroupBox70 = New System.Windows.Forms.GroupBox()
        Me.cbIRxPagarC = New System.Windows.Forms.ComboBox()
        Me.cbIRxPagarV = New System.Windows.Forms.ComboBox()
        Me.Button56 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIRxPagarN = New System.Windows.Forms.TextBox()
        Me.txtIRxPagarC = New System.Windows.Forms.TextBox()
        Me.GroupBox63 = New System.Windows.Forms.GroupBox()
        Me.CBIVAPORCOBRAR = New System.Windows.Forms.ComboBox()
        Me.CBIVAPORCOBRARVAR = New System.Windows.Forms.ComboBox()
        Me.Button53 = New DevExpress.XtraEditors.SimpleButton()
        Me.TXTIVAPORCOBRARNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTIVAXCOBRAR = New System.Windows.Forms.TextBox()
        Me.GroupBox68 = New System.Windows.Forms.GroupBox()
        Me.CBIRXPAGAR = New System.Windows.Forms.ComboBox()
        Me.CBIRXPAGARVAR = New System.Windows.Forms.ComboBox()
        Me.Button50 = New DevExpress.XtraEditors.SimpleButton()
        Me.TXTIRXPAGARNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTIRXPAGARCUENTA = New System.Windows.Forms.TextBox()
        Me.GroupBox69 = New System.Windows.Forms.GroupBox()
        Me.CBPROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.CBPROVEEDORVAR = New System.Windows.Forms.ComboBox()
        Me.Button51 = New DevExpress.XtraEditors.SimpleButton()
        Me.TXTPROVEEDORNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTPROVEEDORCUENTA = New System.Windows.Forms.TextBox()
        Me.GroupBox71 = New System.Windows.Forms.GroupBox()
        Me.Button52 = New DevExpress.XtraEditors.SimpleButton()
        Me.TXTGASTOSNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTGASTOSCUENTA = New System.Windows.Forms.TextBox()
        Me.CBGASTOSVAR = New System.Windows.Forms.ComboBox()
        Me.CBGASTOS = New System.Windows.Forms.ComboBox()
        Me.gbProveedorServiciosPagar = New System.Windows.Forms.GroupBox()
        Me.GroupBox72 = New System.Windows.Forms.GroupBox()
        Me.cbBancoP = New System.Windows.Forms.ComboBox()
        Me.cbBancoPVar = New System.Windows.Forms.ComboBox()
        Me.Button54 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBancoPNombre = New System.Windows.Forms.TextBox()
        Me.txtBancoP = New System.Windows.Forms.TextBox()
        Me.GroupBox73 = New System.Windows.Forms.GroupBox()
        Me.cbIRP = New System.Windows.Forms.ComboBox()
        Me.cbIRPvar = New System.Windows.Forms.ComboBox()
        Me.Button55 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIRPNombre = New System.Windows.Forms.TextBox()
        Me.txtIRP = New System.Windows.Forms.TextBox()
        Me.GroupBox75 = New System.Windows.Forms.GroupBox()
        Me.Button57 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProvPNombre = New System.Windows.Forms.TextBox()
        Me.txtProvP = New System.Windows.Forms.TextBox()
        Me.cbProvPVar = New System.Windows.Forms.ComboBox()
        Me.cbProvP = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbPagoProveedores.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbInstalacion.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbReconexion.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.gbxContado.SuspendLayout()
        Me.GroupBox76.SuspendLayout()
        Me.GroupBox55.SuspendLayout()
        Me.GroupBox53.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox80.SuspendLayout()
        Me.gbxCredito.SuspendLayout()
        Me.GroupBox56.SuspendLayout()
        Me.GroupBox62.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.gbxIVA.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.gbxIR.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox43.SuspendLayout()
        Me.GroupBox48.SuspendLayout()
        Me.GroupBox49.SuspendLayout()
        Me.GroupBox50.SuspendLayout()
        Me.GroupBox51.SuspendLayout()
        Me.gbReciboCaja.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.gbDepositoBancario.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.gbComprasContado.SuspendLayout()
        Me.GroupBox78.SuspendLayout()
        Me.gbCCBanco.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        Me.gbComprasCredito.SuspendLayout()
        Me.GroupBox79.SuspendLayout()
        Me.GroupBox74.SuspendLayout()
        Me.GroupBox36.SuspendLayout()
        Me.gbImpuestos.SuspendLayout()
        Me.GroupBox42.SuspendLayout()
        Me.GroupBox40.SuspendLayout()
        Me.GroupBox41.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.GroupBox35.SuspendLayout()
        Me.GroupBox37.SuspendLayout()
        Me.GroupBox38.SuspendLayout()
        Me.GroupBox39.SuspendLayout()
        Me.gbNotaCredito.SuspendLayout()
        Me.GroupBox44.SuspendLayout()
        Me.GroupBox47.SuspendLayout()
        Me.gbNotaDebito.SuspendLayout()
        Me.GroupBox45.SuspendLayout()
        Me.GroupBox46.SuspendLayout()
        Me.GroupBox52.SuspendLayout()
        Me.GroupBox58.SuspendLayout()
        Me.GroupBox59.SuspendLayout()
        Me.GroupBox60.SuspendLayout()
        Me.GroupBox61.SuspendLayout()
        Me.gbAlcaldia.SuspendLayout()
        Me.GroupBox54.SuspendLayout()
        Me.GroupBox57.SuspendLayout()
        Me.gbMttoValor.SuspendLayout()
        Me.GroupBox64.SuspendLayout()
        Me.gbexgreso.SuspendLayout()
        Me.gbPagoProductos.SuspendLayout()
        Me.GroupBox65.SuspendLayout()
        Me.GroupBox66.SuspendLayout()
        Me.GroupBox67.SuspendLayout()
        Me.gbProveedoresServicios.SuspendLayout()
        Me.GroupBox77.SuspendLayout()
        Me.GroupBox70.SuspendLayout()
        Me.GroupBox63.SuspendLayout()
        Me.GroupBox68.SuspendLayout()
        Me.GroupBox69.SuspendLayout()
        Me.GroupBox71.SuspendLayout()
        Me.gbProveedorServiciosPagar.SuspendLayout()
        Me.GroupBox72.SuspendLayout()
        Me.GroupBox73.SuspendLayout()
        Me.GroupBox75.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgFacturacionCliente)
        Me.GroupBox1.Controls.Add(Me.cbEsquema)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbTipoComp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.cbTipoProv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgFacturacionCliente
        '
        Me.dgFacturacionCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.dgFacturacionCliente.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturacionCliente.DataMember = ""
        Me.dgFacturacionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturacionCliente.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturacionCliente.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 155)
        Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
        Me.dgFacturacionCliente.Size = New System.Drawing.Size(888, 336)
        Me.dgFacturacionCliente.TabIndex = 150
        Me.dgFacturacionCliente.Visible = False
        '
        'cbEsquema
        '
        Me.cbEsquema.Location = New System.Drawing.Point(167, 45)
        Me.cbEsquema.Name = "cbEsquema"
        Me.cbEsquema.Size = New System.Drawing.Size(265, 21)
        Me.cbEsquema.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 26)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Tipo Plantilla"
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(598, 45)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(288, 21)
        Me.cbTipoComp.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(448, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 26)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Tipo Comprobante:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(167, 17)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(168, 20)
        Me.txtTipo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(453, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(598, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(288, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cbTipoProv
        '
        Me.cbTipoProv.Location = New System.Drawing.Point(168, 73)
        Me.cbTipoProv.Name = "cbTipoProv"
        Me.cbTipoProv.Size = New System.Drawing.Size(264, 21)
        Me.cbTipoProv.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 26)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Esquema de Plantilla"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 63)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 28)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(920, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 105)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'gbPagoProveedores
        '
        Me.gbPagoProveedores.Controls.Add(Me.GroupBox6)
        Me.gbPagoProveedores.Controls.Add(Me.GroupBox4)
        Me.gbPagoProveedores.Controls.Add(Me.GroupBox5)
        Me.gbPagoProveedores.Controls.Add(Me.GroupBox3)
        Me.gbPagoProveedores.Location = New System.Drawing.Point(8, 107)
        Me.gbPagoProveedores.Name = "gbPagoProveedores"
        Me.gbPagoProveedores.Size = New System.Drawing.Size(1000, 319)
        Me.gbPagoProveedores.TabIndex = 2
        Me.gbPagoProveedores.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CbIRC)
        Me.GroupBox6.Controls.Add(Me.CbIRVar)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Controls.Add(Me.txtIRNombre)
        Me.GroupBox6.Controls.Add(Me.txtIRCuenta)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(488, 172)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(464, 130)
        Me.GroupBox6.TabIndex = 46
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "I.R."
        '
        'CbIRC
        '
        Me.CbIRC.Location = New System.Drawing.Point(12, 75)
        Me.CbIRC.Name = "CbIRC"
        Me.CbIRC.Size = New System.Drawing.Size(248, 21)
        Me.CbIRC.TabIndex = 10
        '
        'CbIRVar
        '
        Me.CbIRVar.Location = New System.Drawing.Point(268, 75)
        Me.CbIRVar.Name = "CbIRVar"
        Me.CbIRVar.Size = New System.Drawing.Size(184, 21)
        Me.CbIRVar.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Appearance.Options.UseFont = True
        Me.Button4.Appearance.Options.UseForeColor = True
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(420, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 35)
        Me.Button4.TabIndex = 9
        '
        'txtIRNombre
        '
        Me.txtIRNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRNombre.Location = New System.Drawing.Point(140, 41)
        Me.txtIRNombre.Name = "txtIRNombre"
        Me.txtIRNombre.ReadOnly = True
        Me.txtIRNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRNombre.TabIndex = 100
        '
        'txtIRCuenta
        '
        Me.txtIRCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCuenta.Location = New System.Drawing.Point(20, 41)
        Me.txtIRCuenta.Name = "txtIRCuenta"
        Me.txtIRCuenta.ReadOnly = True
        Me.txtIRCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIRCuenta.TabIndex = 100
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbIVAC)
        Me.GroupBox4.Controls.Add(Me.CbIVAVar)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.txtIVANombre)
        Me.GroupBox4.Controls.Add(Me.txtIVACuenta)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 130)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "I.V.A"
        '
        'cbIVAC
        '
        Me.cbIVAC.Location = New System.Drawing.Point(12, 75)
        Me.cbIVAC.Name = "cbIVAC"
        Me.cbIVAC.Size = New System.Drawing.Size(248, 21)
        Me.cbIVAC.TabIndex = 7
        '
        'CbIVAVar
        '
        Me.CbIVAVar.Location = New System.Drawing.Point(268, 75)
        Me.CbIVAVar.Name = "CbIVAVar"
        Me.CbIVAVar.Size = New System.Drawing.Size(184, 21)
        Me.CbIVAVar.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Appearance.Options.UseFont = True
        Me.Button3.Appearance.Options.UseForeColor = True
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(420, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 35)
        Me.Button3.TabIndex = 7
        '
        'txtIVANombre
        '
        Me.txtIVANombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVANombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVANombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVANombre.Location = New System.Drawing.Point(132, 41)
        Me.txtIVANombre.Name = "txtIVANombre"
        Me.txtIVANombre.ReadOnly = True
        Me.txtIVANombre.Size = New System.Drawing.Size(280, 20)
        Me.txtIVANombre.TabIndex = 100
        '
        'txtIVACuenta
        '
        Me.txtIVACuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVACuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVACuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACuenta.Location = New System.Drawing.Point(12, 41)
        Me.txtIVACuenta.Name = "txtIVACuenta"
        Me.txtIVACuenta.ReadOnly = True
        Me.txtIVACuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIVACuenta.TabIndex = 100
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.cbBanC)
        Me.GroupBox5.Controls.Add(Me.cbBancVar)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(488, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BANCO"
        '
        'cbBanC
        '
        Me.cbBanC.ItemHeight = 13
        Me.cbBanC.Location = New System.Drawing.Point(12, 80)
        Me.cbBanC.Name = "cbBanC"
        Me.cbBanC.Size = New System.Drawing.Size(248, 21)
        Me.cbBanC.TabIndex = 5
        '
        'cbBancVar
        '
        Me.cbBancVar.ItemHeight = 13
        Me.cbBancVar.Location = New System.Drawing.Point(268, 80)
        Me.cbBancVar.Name = "cbBancVar"
        Me.cbBancVar.Size = New System.Drawing.Size(184, 21)
        Me.cbBancVar.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CbProvVar)
        Me.GroupBox3.Controls.Add(Me.CbProvC)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PROVEEDOR"
        '
        'CbProvVar
        '
        Me.CbProvVar.Location = New System.Drawing.Point(268, 80)
        Me.CbProvVar.Name = "CbProvVar"
        Me.CbProvVar.Size = New System.Drawing.Size(184, 21)
        Me.CbProvVar.TabIndex = 3
        '
        'CbProvC
        '
        Me.CbProvC.Location = New System.Drawing.Point(12, 80)
        Me.CbProvC.Name = "CbProvC"
        Me.CbProvC.Size = New System.Drawing.Size(248, 21)
        Me.CbProvC.TabIndex = 2
        '
        'gbBlank
        '
        Me.gbBlank.Location = New System.Drawing.Point(8, 116)
        Me.gbBlank.Name = "gbBlank"
        Me.gbBlank.Size = New System.Drawing.Size(1000, 319)
        Me.gbBlank.TabIndex = 7
        Me.gbBlank.TabStop = False
        '
        'gbInstalacion
        '
        Me.gbInstalacion.Controls.Add(Me.GroupBox7)
        Me.gbInstalacion.Controls.Add(Me.GroupBox11)
        Me.gbInstalacion.Location = New System.Drawing.Point(8, 116)
        Me.gbInstalacion.Name = "gbInstalacion"
        Me.gbInstalacion.Size = New System.Drawing.Size(1000, 301)
        Me.gbInstalacion.TabIndex = 8
        Me.gbInstalacion.TabStop = False
        Me.gbInstalacion.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cbBancosVar)
        Me.GroupBox7.Controls.Add(Me.cbBancos)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(512, 34)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox7.TabIndex = 44
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "BANCOS"
        '
        'cbBancosVar
        '
        Me.cbBancosVar.Location = New System.Drawing.Point(264, 60)
        Me.cbBancosVar.Name = "cbBancosVar"
        Me.cbBancosVar.Size = New System.Drawing.Size(184, 21)
        Me.cbBancosVar.TabIndex = 3
        '
        'cbBancos
        '
        Me.cbBancos.Location = New System.Drawing.Point(8, 60)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(248, 21)
        Me.cbBancos.TabIndex = 2
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtDepCuenta)
        Me.GroupBox11.Controls.Add(Me.txtDept)
        Me.GroupBox11.Controls.Add(Me.cbDeptVar)
        Me.GroupBox11.Controls.Add(Me.cbDeptC)
        Me.GroupBox11.Controls.Add(Me.Button8)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox11.Location = New System.Drawing.Point(32, 34)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox11.TabIndex = 43
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "DEPOSITO EN GARANTIA"
        '
        'txtDepCuenta
        '
        Me.txtDepCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtDepCuenta.Name = "txtDepCuenta"
        Me.txtDepCuenta.ReadOnly = True
        Me.txtDepCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtDepCuenta.TabIndex = 100
        '
        'txtDept
        '
        Me.txtDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.Location = New System.Drawing.Point(128, 26)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(272, 20)
        Me.txtDept.TabIndex = 100
        '
        'cbDeptVar
        '
        Me.cbDeptVar.Location = New System.Drawing.Point(264, 60)
        Me.cbDeptVar.Name = "cbDeptVar"
        Me.cbDeptVar.Size = New System.Drawing.Size(184, 21)
        Me.cbDeptVar.TabIndex = 3
        '
        'cbDeptC
        '
        Me.cbDeptC.Location = New System.Drawing.Point(8, 60)
        Me.cbDeptC.Name = "cbDeptC"
        Me.cbDeptC.Size = New System.Drawing.Size(248, 21)
        Me.cbDeptC.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button8.Appearance.Options.UseFont = True
        Me.Button8.Appearance.Options.UseForeColor = True
        Me.Button8.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(416, 17)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 35)
        Me.Button8.TabIndex = 1
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox10.Controls.Add(Me.cbBancoVarReco)
        Me.GroupBox10.Controls.Add(Me.cbBancoReco)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox10.Location = New System.Drawing.Point(272, 198)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox10.TabIndex = 45
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "BANCOS"
        '
        'cbBancoVarReco
        '
        Me.cbBancoVarReco.ItemHeight = 13
        Me.cbBancoVarReco.Location = New System.Drawing.Point(264, 60)
        Me.cbBancoVarReco.Name = "cbBancoVarReco"
        Me.cbBancoVarReco.Size = New System.Drawing.Size(184, 21)
        Me.cbBancoVarReco.TabIndex = 3
        '
        'cbBancoReco
        '
        Me.cbBancoReco.ItemHeight = 13
        Me.cbBancoReco.Location = New System.Drawing.Point(8, 60)
        Me.cbBancoReco.Name = "cbBancoReco"
        Me.cbBancoReco.Size = New System.Drawing.Size(248, 21)
        Me.cbBancoReco.TabIndex = 2
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox9.Controls.Add(Me.cbProvVarReco)
        Me.GroupBox9.Controls.Add(Me.cbProvReco)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(512, 26)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox9.TabIndex = 44
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "PROVEEDOR"
        '
        'cbProvVarReco
        '
        Me.cbProvVarReco.ItemHeight = 13
        Me.cbProvVarReco.Location = New System.Drawing.Point(264, 60)
        Me.cbProvVarReco.Name = "cbProvVarReco"
        Me.cbProvVarReco.Size = New System.Drawing.Size(184, 21)
        Me.cbProvVarReco.TabIndex = 3
        '
        'cbProvReco
        '
        Me.cbProvReco.ItemHeight = 13
        Me.cbProvReco.Location = New System.Drawing.Point(8, 60)
        Me.cbProvReco.Name = "cbProvReco"
        Me.cbProvReco.Size = New System.Drawing.Size(248, 21)
        Me.cbProvReco.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.txtRecoCuenta)
        Me.GroupBox8.Controls.Add(Me.txtReco)
        Me.GroupBox8.Controls.Add(Me.cbRecoVar)
        Me.GroupBox8.Controls.Add(Me.cbRecoC)
        Me.GroupBox8.Controls.Add(Me.Button5)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(24, 26)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox8.TabIndex = 43
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "I.V.A"
        '
        'txtRecoCuenta
        '
        Me.txtRecoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecoCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecoCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtRecoCuenta.Name = "txtRecoCuenta"
        Me.txtRecoCuenta.ReadOnly = True
        Me.txtRecoCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtRecoCuenta.TabIndex = 100
        '
        'txtReco
        '
        Me.txtReco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReco.Location = New System.Drawing.Point(128, 26)
        Me.txtReco.Name = "txtReco"
        Me.txtReco.ReadOnly = True
        Me.txtReco.Size = New System.Drawing.Size(272, 20)
        Me.txtReco.TabIndex = 100
        '
        'cbRecoVar
        '
        Me.cbRecoVar.ItemHeight = 13
        Me.cbRecoVar.Location = New System.Drawing.Point(264, 60)
        Me.cbRecoVar.Name = "cbRecoVar"
        Me.cbRecoVar.Size = New System.Drawing.Size(184, 21)
        Me.cbRecoVar.TabIndex = 3
        '
        'cbRecoC
        '
        Me.cbRecoC.ItemHeight = 13
        Me.cbRecoC.Location = New System.Drawing.Point(8, 60)
        Me.cbRecoC.Name = "cbRecoC"
        Me.cbRecoC.Size = New System.Drawing.Size(248, 21)
        Me.cbRecoC.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button5.Appearance.Options.UseFont = True
        Me.Button5.Appearance.Options.UseForeColor = True
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(416, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 35)
        Me.Button5.TabIndex = 1
        '
        'gbReconexion
        '
        Me.gbReconexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbReconexion.Controls.Add(Me.GroupBox10)
        Me.gbReconexion.Controls.Add(Me.GroupBox9)
        Me.gbReconexion.Controls.Add(Me.GroupBox8)
        Me.gbReconexion.Location = New System.Drawing.Point(8, 116)
        Me.gbReconexion.Name = "gbReconexion"
        Me.gbReconexion.Size = New System.Drawing.Size(1000, 301)
        Me.gbReconexion.TabIndex = 9
        Me.gbReconexion.TabStop = False
        Me.gbReconexion.Visible = False
        '
        'gbCaja
        '
        Me.gbCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbCaja.Controls.Add(Me.GroupBox15)
        Me.gbCaja.Location = New System.Drawing.Point(8, 116)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(1000, 301)
        Me.gbCaja.TabIndex = 10
        Me.gbCaja.TabStop = False
        Me.gbCaja.Visible = False
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox15.Controls.Add(Me.cbCajaVar)
        Me.GroupBox15.Controls.Add(Me.cbCajaConcep)
        Me.GroupBox15.Controls.Add(Me.txtCajaCuenta)
        Me.GroupBox15.Controls.Add(Me.txtCaja)
        Me.GroupBox15.Controls.Add(Me.Button6)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox15.Location = New System.Drawing.Point(264, 17)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox15.TabIndex = 43
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "CAJA"
        '
        'cbCajaVar
        '
        Me.cbCajaVar.ItemHeight = 13
        Me.cbCajaVar.Location = New System.Drawing.Point(268, 58)
        Me.cbCajaVar.Name = "cbCajaVar"
        Me.cbCajaVar.Size = New System.Drawing.Size(184, 21)
        Me.cbCajaVar.TabIndex = 102
        Me.cbCajaVar.Visible = False
        '
        'cbCajaConcep
        '
        Me.cbCajaConcep.ItemHeight = 13
        Me.cbCajaConcep.Location = New System.Drawing.Point(12, 58)
        Me.cbCajaConcep.Name = "cbCajaConcep"
        Me.cbCajaConcep.Size = New System.Drawing.Size(248, 21)
        Me.cbCajaConcep.TabIndex = 101
        Me.cbCajaConcep.Visible = False
        '
        'txtCajaCuenta
        '
        Me.txtCajaCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtCajaCuenta.Name = "txtCajaCuenta"
        Me.txtCajaCuenta.ReadOnly = True
        Me.txtCajaCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtCajaCuenta.TabIndex = 100
        '
        'txtCaja
        '
        Me.txtCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaja.Location = New System.Drawing.Point(128, 26)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.ReadOnly = True
        Me.txtCaja.Size = New System.Drawing.Size(272, 20)
        Me.txtCaja.TabIndex = 100
        '
        'Button6
        '
        Me.Button6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Appearance.Options.UseFont = True
        Me.Button6.Appearance.Options.UseForeColor = True
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(416, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 35)
        Me.Button6.TabIndex = 1
        '
        'gbxContado
        '
        Me.gbxContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbxContado.Controls.Add(Me.GroupBox76)
        Me.gbxContado.Controls.Add(Me.GroupBox55)
        Me.gbxContado.Controls.Add(Me.GroupBox53)
        Me.gbxContado.Controls.Add(Me.GroupBox25)
        Me.gbxContado.Controls.Add(Me.GroupBox12)
        Me.gbxContado.Controls.Add(Me.GroupBox14)
        Me.gbxContado.Controls.Add(Me.GroupBox13)
        Me.gbxContado.Controls.Add(Me.GroupBox80)
        Me.gbxContado.Location = New System.Drawing.Point(8, 116)
        Me.gbxContado.Name = "gbxContado"
        Me.gbxContado.Size = New System.Drawing.Size(1000, 439)
        Me.gbxContado.TabIndex = 11
        Me.gbxContado.TabStop = False
        Me.gbxContado.Visible = False
        '
        'GroupBox76
        '
        Me.GroupBox76.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox76.Controls.Add(Me.cbIRAlcVariable)
        Me.GroupBox76.Controls.Add(Me.cbIRAlcConcepto)
        Me.GroupBox76.Controls.Add(Me.txtIRAlcCuenta)
        Me.GroupBox76.Controls.Add(Me.txtIRAlcNombre)
        Me.GroupBox76.Controls.Add(Me.Button60)
        Me.GroupBox76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox76.Location = New System.Drawing.Point(32, 319)
        Me.GroupBox76.Name = "GroupBox76"
        Me.GroupBox76.Size = New System.Drawing.Size(464, 103)
        Me.GroupBox76.TabIndex = 49
        Me.GroupBox76.TabStop = False
        Me.GroupBox76.Text = "I.R. ALCALDIA sobre Venta"
        '
        'cbIRAlcVariable
        '
        Me.cbIRAlcVariable.ItemHeight = 13
        Me.cbIRAlcVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbIRAlcVariable.Name = "cbIRAlcVariable"
        Me.cbIRAlcVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIRAlcVariable.TabIndex = 102
        '
        'cbIRAlcConcepto
        '
        Me.cbIRAlcConcepto.ItemHeight = 13
        Me.cbIRAlcConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIRAlcConcepto.Name = "cbIRAlcConcepto"
        Me.cbIRAlcConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIRAlcConcepto.TabIndex = 101
        '
        'txtIRAlcCuenta
        '
        Me.txtIRAlcCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRAlcCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRAlcCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRAlcCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtIRAlcCuenta.Name = "txtIRAlcCuenta"
        Me.txtIRAlcCuenta.ReadOnly = True
        Me.txtIRAlcCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIRAlcCuenta.TabIndex = 100
        '
        'txtIRAlcNombre
        '
        Me.txtIRAlcNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRAlcNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRAlcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRAlcNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRAlcNombre.Name = "txtIRAlcNombre"
        Me.txtIRAlcNombre.ReadOnly = True
        Me.txtIRAlcNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRAlcNombre.TabIndex = 100
        '
        'Button60
        '
        Me.Button60.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button60.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button60.Appearance.Options.UseFont = True
        Me.Button60.Appearance.Options.UseForeColor = True
        Me.Button60.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button60.Image = CType(resources.GetObject("Button60.Image"), System.Drawing.Image)
        Me.Button60.Location = New System.Drawing.Point(416, 17)
        Me.Button60.Name = "Button60"
        Me.Button60.Size = New System.Drawing.Size(32, 35)
        Me.Button60.TabIndex = 1
        '
        'GroupBox55
        '
        Me.GroupBox55.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox55.Controls.Add(Me.cbVarInventarioIngr)
        Me.GroupBox55.Controls.Add(Me.cbInventarioVentaIngr)
        Me.GroupBox55.Controls.Add(Me.txtInventarioCuentaIngr)
        Me.GroupBox55.Controls.Add(Me.txtInventarioNombreIngr)
        Me.GroupBox55.Controls.Add(Me.Button37)
        Me.GroupBox55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox55.Location = New System.Drawing.Point(512, 215)
        Me.GroupBox55.Name = "GroupBox55"
        Me.GroupBox55.Size = New System.Drawing.Size(464, 95)
        Me.GroupBox55.TabIndex = 48
        Me.GroupBox55.TabStop = False
        Me.GroupBox55.Text = "INVENTARIO"
        '
        'cbVarInventarioIngr
        '
        Me.cbVarInventarioIngr.ItemHeight = 13
        Me.cbVarInventarioIngr.Location = New System.Drawing.Point(268, 60)
        Me.cbVarInventarioIngr.Name = "cbVarInventarioIngr"
        Me.cbVarInventarioIngr.Size = New System.Drawing.Size(184, 21)
        Me.cbVarInventarioIngr.TabIndex = 102
        '
        'cbInventarioVentaIngr
        '
        Me.cbInventarioVentaIngr.ItemHeight = 13
        Me.cbInventarioVentaIngr.Location = New System.Drawing.Point(8, 60)
        Me.cbInventarioVentaIngr.Name = "cbInventarioVentaIngr"
        Me.cbInventarioVentaIngr.Size = New System.Drawing.Size(248, 21)
        Me.cbInventarioVentaIngr.TabIndex = 101
        '
        'txtInventarioCuentaIngr
        '
        Me.txtInventarioCuentaIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInventarioCuentaIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventarioCuentaIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioCuentaIngr.Location = New System.Drawing.Point(8, 26)
        Me.txtInventarioCuentaIngr.Name = "txtInventarioCuentaIngr"
        Me.txtInventarioCuentaIngr.ReadOnly = True
        Me.txtInventarioCuentaIngr.Size = New System.Drawing.Size(112, 20)
        Me.txtInventarioCuentaIngr.TabIndex = 100
        '
        'txtInventarioNombreIngr
        '
        Me.txtInventarioNombreIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInventarioNombreIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventarioNombreIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioNombreIngr.Location = New System.Drawing.Point(136, 26)
        Me.txtInventarioNombreIngr.Name = "txtInventarioNombreIngr"
        Me.txtInventarioNombreIngr.ReadOnly = True
        Me.txtInventarioNombreIngr.Size = New System.Drawing.Size(272, 20)
        Me.txtInventarioNombreIngr.TabIndex = 100
        '
        'Button37
        '
        Me.Button37.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button37.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button37.Appearance.Options.UseFont = True
        Me.Button37.Appearance.Options.UseForeColor = True
        Me.Button37.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button37.Image = CType(resources.GetObject("Button37.Image"), System.Drawing.Image)
        Me.Button37.Location = New System.Drawing.Point(416, 17)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(32, 35)
        Me.Button37.TabIndex = 1
        '
        'GroupBox53
        '
        Me.GroupBox53.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox53.Controls.Add(Me.cbVarCostoVentaIngr)
        Me.GroupBox53.Controls.Add(Me.cbConceptoCostoVentaIngr)
        Me.GroupBox53.Controls.Add(Me.txtCostoVentaCuentaIngr)
        Me.GroupBox53.Controls.Add(Me.txtCostoVentaNombreIngr)
        Me.GroupBox53.Controls.Add(Me.Button36)
        Me.GroupBox53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox53.Location = New System.Drawing.Point(32, 215)
        Me.GroupBox53.Name = "GroupBox53"
        Me.GroupBox53.Size = New System.Drawing.Size(464, 95)
        Me.GroupBox53.TabIndex = 47
        Me.GroupBox53.TabStop = False
        Me.GroupBox53.Text = "COSTO DE VENTA"
        '
        'cbVarCostoVentaIngr
        '
        Me.cbVarCostoVentaIngr.ItemHeight = 13
        Me.cbVarCostoVentaIngr.Location = New System.Drawing.Point(268, 60)
        Me.cbVarCostoVentaIngr.Name = "cbVarCostoVentaIngr"
        Me.cbVarCostoVentaIngr.Size = New System.Drawing.Size(184, 21)
        Me.cbVarCostoVentaIngr.TabIndex = 102
        '
        'cbConceptoCostoVentaIngr
        '
        Me.cbConceptoCostoVentaIngr.ItemHeight = 13
        Me.cbConceptoCostoVentaIngr.Location = New System.Drawing.Point(8, 60)
        Me.cbConceptoCostoVentaIngr.Name = "cbConceptoCostoVentaIngr"
        Me.cbConceptoCostoVentaIngr.Size = New System.Drawing.Size(248, 21)
        Me.cbConceptoCostoVentaIngr.TabIndex = 101
        '
        'txtCostoVentaCuentaIngr
        '
        Me.txtCostoVentaCuentaIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoVentaCuentaIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoVentaCuentaIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoVentaCuentaIngr.Location = New System.Drawing.Point(8, 26)
        Me.txtCostoVentaCuentaIngr.Name = "txtCostoVentaCuentaIngr"
        Me.txtCostoVentaCuentaIngr.ReadOnly = True
        Me.txtCostoVentaCuentaIngr.Size = New System.Drawing.Size(112, 20)
        Me.txtCostoVentaCuentaIngr.TabIndex = 100
        '
        'txtCostoVentaNombreIngr
        '
        Me.txtCostoVentaNombreIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoVentaNombreIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoVentaNombreIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoVentaNombreIngr.Location = New System.Drawing.Point(136, 26)
        Me.txtCostoVentaNombreIngr.Name = "txtCostoVentaNombreIngr"
        Me.txtCostoVentaNombreIngr.ReadOnly = True
        Me.txtCostoVentaNombreIngr.Size = New System.Drawing.Size(272, 20)
        Me.txtCostoVentaNombreIngr.TabIndex = 100
        '
        'Button36
        '
        Me.Button36.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button36.Appearance.Options.UseFont = True
        Me.Button36.Appearance.Options.UseForeColor = True
        Me.Button36.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button36.Image = CType(resources.GetObject("Button36.Image"), System.Drawing.Image)
        Me.Button36.Location = New System.Drawing.Point(416, 17)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(32, 35)
        Me.Button36.TabIndex = 1
        '
        'GroupBox25
        '
        Me.GroupBox25.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox25.Controls.Add(Me.cbIRContadoVariable)
        Me.GroupBox25.Controls.Add(Me.cbIRContadoConcepto)
        Me.GroupBox25.Controls.Add(Me.txtIRContadoCodigo)
        Me.GroupBox25.Controls.Add(Me.txtIRContadoNombre)
        Me.GroupBox25.Controls.Add(Me.cmdIRCatalogo)
        Me.GroupBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox25.Location = New System.Drawing.Point(512, 112)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(464, 95)
        Me.GroupBox25.TabIndex = 46
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "IR"
        '
        'cbIRContadoVariable
        '
        Me.cbIRContadoVariable.ItemHeight = 13
        Me.cbIRContadoVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbIRContadoVariable.Name = "cbIRContadoVariable"
        Me.cbIRContadoVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIRContadoVariable.TabIndex = 102
        '
        'cbIRContadoConcepto
        '
        Me.cbIRContadoConcepto.ItemHeight = 13
        Me.cbIRContadoConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIRContadoConcepto.Name = "cbIRContadoConcepto"
        Me.cbIRContadoConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIRContadoConcepto.TabIndex = 101
        '
        'txtIRContadoCodigo
        '
        Me.txtIRContadoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRContadoCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRContadoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRContadoCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRContadoCodigo.Name = "txtIRContadoCodigo"
        Me.txtIRContadoCodigo.ReadOnly = True
        Me.txtIRContadoCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRContadoCodigo.TabIndex = 100
        '
        'txtIRContadoNombre
        '
        Me.txtIRContadoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRContadoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRContadoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRContadoNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRContadoNombre.Name = "txtIRContadoNombre"
        Me.txtIRContadoNombre.ReadOnly = True
        Me.txtIRContadoNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRContadoNombre.TabIndex = 100
        '
        'cmdIRCatalogo
        '
        Me.cmdIRCatalogo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRCatalogo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIRCatalogo.Appearance.Options.UseFont = True
        Me.cmdIRCatalogo.Appearance.Options.UseForeColor = True
        Me.cmdIRCatalogo.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIRCatalogo.Image = CType(resources.GetObject("cmdIRCatalogo.Image"), System.Drawing.Image)
        Me.cmdIRCatalogo.Location = New System.Drawing.Point(416, 17)
        Me.cmdIRCatalogo.Name = "cmdIRCatalogo"
        Me.cmdIRCatalogo.Size = New System.Drawing.Size(32, 35)
        Me.cmdIRCatalogo.TabIndex = 1
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox12.Controls.Add(Me.cbVarIVAIngr)
        Me.GroupBox12.Controls.Add(Me.cbConceptoIVAIngr)
        Me.GroupBox12.Controls.Add(Me.txtIVACuentaIngr)
        Me.GroupBox12.Controls.Add(Me.txtIVAIngr)
        Me.GroupBox12.Controls.Add(Me.Button7)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox12.Location = New System.Drawing.Point(32, 112)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(464, 95)
        Me.GroupBox12.TabIndex = 45
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "I.V.A."
        '
        'cbVarIVAIngr
        '
        Me.cbVarIVAIngr.ItemHeight = 13
        Me.cbVarIVAIngr.Location = New System.Drawing.Point(268, 60)
        Me.cbVarIVAIngr.Name = "cbVarIVAIngr"
        Me.cbVarIVAIngr.Size = New System.Drawing.Size(184, 21)
        Me.cbVarIVAIngr.TabIndex = 102
        '
        'cbConceptoIVAIngr
        '
        Me.cbConceptoIVAIngr.ItemHeight = 13
        Me.cbConceptoIVAIngr.Location = New System.Drawing.Point(8, 60)
        Me.cbConceptoIVAIngr.Name = "cbConceptoIVAIngr"
        Me.cbConceptoIVAIngr.Size = New System.Drawing.Size(248, 21)
        Me.cbConceptoIVAIngr.TabIndex = 101
        '
        'txtIVACuentaIngr
        '
        Me.txtIVACuentaIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVACuentaIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVACuentaIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACuentaIngr.Location = New System.Drawing.Point(8, 26)
        Me.txtIVACuentaIngr.Name = "txtIVACuentaIngr"
        Me.txtIVACuentaIngr.ReadOnly = True
        Me.txtIVACuentaIngr.Size = New System.Drawing.Size(112, 20)
        Me.txtIVACuentaIngr.TabIndex = 100
        '
        'txtIVAIngr
        '
        Me.txtIVAIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVAIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAIngr.Location = New System.Drawing.Point(136, 26)
        Me.txtIVAIngr.Name = "txtIVAIngr"
        Me.txtIVAIngr.ReadOnly = True
        Me.txtIVAIngr.Size = New System.Drawing.Size(272, 20)
        Me.txtIVAIngr.TabIndex = 100
        '
        'Button7
        '
        Me.Button7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button7.Appearance.Options.UseFont = True
        Me.Button7.Appearance.Options.UseForeColor = True
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(416, 17)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 35)
        Me.Button7.TabIndex = 1
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox14.Controls.Add(Me.txtIngrCuenta)
        Me.GroupBox14.Controls.Add(Me.txtIngrNombre)
        Me.GroupBox14.Controls.Add(Me.cbIngrVariable)
        Me.GroupBox14.Controls.Add(Me.cbIngrConceptos)
        Me.GroupBox14.Controls.Add(Me.Button2)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox14.Location = New System.Drawing.Point(512, 9)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(464, 94)
        Me.GroupBox14.TabIndex = 44
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "CUENTA DE INGRESOS"
        '
        'txtIngrCuenta
        '
        Me.txtIngrCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngrCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIngrCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngrCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtIngrCuenta.Name = "txtIngrCuenta"
        Me.txtIngrCuenta.ReadOnly = True
        Me.txtIngrCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIngrCuenta.TabIndex = 100
        '
        'txtIngrNombre
        '
        Me.txtIngrNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngrNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIngrNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngrNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIngrNombre.Name = "txtIngrNombre"
        Me.txtIngrNombre.ReadOnly = True
        Me.txtIngrNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIngrNombre.TabIndex = 100
        '
        'cbIngrVariable
        '
        Me.cbIngrVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIngrVariable.ItemHeight = 13
        Me.cbIngrVariable.Location = New System.Drawing.Point(264, 60)
        Me.cbIngrVariable.Name = "cbIngrVariable"
        Me.cbIngrVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIngrVariable.TabIndex = 3
        '
        'cbIngrConceptos
        '
        Me.cbIngrConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIngrConceptos.ItemHeight = 13
        Me.cbIngrConceptos.Location = New System.Drawing.Point(8, 60)
        Me.cbIngrConceptos.Name = "cbIngrConceptos"
        Me.cbIngrConceptos.Size = New System.Drawing.Size(248, 21)
        Me.cbIngrConceptos.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.Appearance.Options.UseForeColor = True
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(416, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 35)
        Me.Button2.TabIndex = 1
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox13.Controls.Add(Me.cbCajaVariable)
        Me.GroupBox13.Controls.Add(Me.cbCajaConcepto)
        Me.GroupBox13.Controls.Add(Me.txtCajaCuentaContado)
        Me.GroupBox13.Controls.Add(Me.txtCajaNombreContado)
        Me.GroupBox13.Controls.Add(Me.Button1)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox13.Location = New System.Drawing.Point(32, 9)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(464, 94)
        Me.GroupBox13.TabIndex = 43
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "CAJA "
        '
        'cbCajaVariable
        '
        Me.cbCajaVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCajaVariable.ItemHeight = 13
        Me.cbCajaVariable.Location = New System.Drawing.Point(268, 58)
        Me.cbCajaVariable.Name = "cbCajaVariable"
        Me.cbCajaVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbCajaVariable.TabIndex = 102
        '
        'cbCajaConcepto
        '
        Me.cbCajaConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCajaConcepto.ItemHeight = 13
        Me.cbCajaConcepto.Location = New System.Drawing.Point(12, 58)
        Me.cbCajaConcepto.Name = "cbCajaConcepto"
        Me.cbCajaConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbCajaConcepto.TabIndex = 101
        '
        'txtCajaCuentaContado
        '
        Me.txtCajaCuentaContado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaCuentaContado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaCuentaContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaCuentaContado.Location = New System.Drawing.Point(16, 26)
        Me.txtCajaCuentaContado.Name = "txtCajaCuentaContado"
        Me.txtCajaCuentaContado.ReadOnly = True
        Me.txtCajaCuentaContado.Size = New System.Drawing.Size(112, 20)
        Me.txtCajaCuentaContado.TabIndex = 100
        '
        'txtCajaNombreContado
        '
        Me.txtCajaNombreContado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaNombreContado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaNombreContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaNombreContado.Location = New System.Drawing.Point(136, 26)
        Me.txtCajaNombreContado.Name = "txtCajaNombreContado"
        Me.txtCajaNombreContado.ReadOnly = True
        Me.txtCajaNombreContado.Size = New System.Drawing.Size(272, 20)
        Me.txtCajaNombreContado.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Appearance.Options.UseForeColor = True
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(416, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 35)
        Me.Button1.TabIndex = 1
        '
        'GroupBox80
        '
        Me.GroupBox80.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox80.Controls.Add(Me.cbdevolucionvariable)
        Me.GroupBox80.Controls.Add(Me.cbdevolucionconcepto)
        Me.GroupBox80.Controls.Add(Me.txtdevolucioncuenta)
        Me.GroupBox80.Controls.Add(Me.txtdevolucionnombre)
        Me.GroupBox80.Controls.Add(Me.Button64)
        Me.GroupBox80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox80.Location = New System.Drawing.Point(512, 319)
        Me.GroupBox80.Name = "GroupBox80"
        Me.GroupBox80.Size = New System.Drawing.Size(464, 103)
        Me.GroupBox80.TabIndex = 49
        Me.GroupBox80.TabStop = False
        Me.GroupBox80.Text = "DEVOLUCION"
        '
        'cbdevolucionvariable
        '
        Me.cbdevolucionvariable.ItemHeight = 13
        Me.cbdevolucionvariable.Location = New System.Drawing.Point(268, 60)
        Me.cbdevolucionvariable.Name = "cbdevolucionvariable"
        Me.cbdevolucionvariable.Size = New System.Drawing.Size(184, 21)
        Me.cbdevolucionvariable.TabIndex = 102
        '
        'cbdevolucionconcepto
        '
        Me.cbdevolucionconcepto.ItemHeight = 13
        Me.cbdevolucionconcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbdevolucionconcepto.Name = "cbdevolucionconcepto"
        Me.cbdevolucionconcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbdevolucionconcepto.TabIndex = 101
        '
        'txtdevolucioncuenta
        '
        Me.txtdevolucioncuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdevolucioncuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdevolucioncuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdevolucioncuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtdevolucioncuenta.Name = "txtdevolucioncuenta"
        Me.txtdevolucioncuenta.ReadOnly = True
        Me.txtdevolucioncuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtdevolucioncuenta.TabIndex = 100
        '
        'txtdevolucionnombre
        '
        Me.txtdevolucionnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdevolucionnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdevolucionnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdevolucionnombre.Location = New System.Drawing.Point(136, 26)
        Me.txtdevolucionnombre.Name = "txtdevolucionnombre"
        Me.txtdevolucionnombre.ReadOnly = True
        Me.txtdevolucionnombre.Size = New System.Drawing.Size(272, 20)
        Me.txtdevolucionnombre.TabIndex = 100
        '
        'Button64
        '
        Me.Button64.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button64.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button64.Appearance.Options.UseFont = True
        Me.Button64.Appearance.Options.UseForeColor = True
        Me.Button64.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button64.Image = CType(resources.GetObject("Button64.Image"), System.Drawing.Image)
        Me.Button64.Location = New System.Drawing.Point(416, 17)
        Me.Button64.Name = "Button64"
        Me.Button64.Size = New System.Drawing.Size(32, 35)
        Me.Button64.TabIndex = 1
        '
        'gbxCredito
        '
        Me.gbxCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbxCredito.Controls.Add(Me.GroupBox56)
        Me.gbxCredito.Controls.Add(Me.GroupBox62)
        Me.gbxCredito.Controls.Add(Me.GroupBox17)
        Me.gbxCredito.Controls.Add(Me.GroupBox18)
        Me.gbxCredito.Location = New System.Drawing.Point(8, 116)
        Me.gbxCredito.Name = "gbxCredito"
        Me.gbxCredito.Size = New System.Drawing.Size(1000, 301)
        Me.gbxCredito.TabIndex = 12
        Me.gbxCredito.TabStop = False
        Me.gbxCredito.Visible = False
        '
        'GroupBox56
        '
        Me.GroupBox56.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox56.Controls.Add(Me.cbInventarioVariable)
        Me.GroupBox56.Controls.Add(Me.cbInventarioConcepto)
        Me.GroupBox56.Controls.Add(Me.txtInventarioCred)
        Me.GroupBox56.Controls.Add(Me.txtNombreInventarioCred)
        Me.GroupBox56.Controls.Add(Me.Button43)
        Me.GroupBox56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox56.Location = New System.Drawing.Point(520, 172)
        Me.GroupBox56.Name = "GroupBox56"
        Me.GroupBox56.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox56.TabIndex = 50
        Me.GroupBox56.TabStop = False
        Me.GroupBox56.Text = "INVENTARIO"
        '
        'cbInventarioVariable
        '
        Me.cbInventarioVariable.ItemHeight = 13
        Me.cbInventarioVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbInventarioVariable.Name = "cbInventarioVariable"
        Me.cbInventarioVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbInventarioVariable.TabIndex = 102
        '
        'cbInventarioConcepto
        '
        Me.cbInventarioConcepto.ItemHeight = 13
        Me.cbInventarioConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbInventarioConcepto.Name = "cbInventarioConcepto"
        Me.cbInventarioConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbInventarioConcepto.TabIndex = 101
        '
        'txtInventarioCred
        '
        Me.txtInventarioCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInventarioCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInventarioCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioCred.Location = New System.Drawing.Point(8, 26)
        Me.txtInventarioCred.Name = "txtInventarioCred"
        Me.txtInventarioCred.ReadOnly = True
        Me.txtInventarioCred.Size = New System.Drawing.Size(112, 20)
        Me.txtInventarioCred.TabIndex = 100
        '
        'txtNombreInventarioCred
        '
        Me.txtNombreInventarioCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreInventarioCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreInventarioCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreInventarioCred.Location = New System.Drawing.Point(136, 26)
        Me.txtNombreInventarioCred.Name = "txtNombreInventarioCred"
        Me.txtNombreInventarioCred.ReadOnly = True
        Me.txtNombreInventarioCred.Size = New System.Drawing.Size(272, 20)
        Me.txtNombreInventarioCred.TabIndex = 100
        '
        'Button43
        '
        Me.Button43.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button43.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button43.Appearance.Options.UseFont = True
        Me.Button43.Appearance.Options.UseForeColor = True
        Me.Button43.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button43.Image = CType(resources.GetObject("Button43.Image"), System.Drawing.Image)
        Me.Button43.Location = New System.Drawing.Point(416, 17)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(32, 35)
        Me.Button43.TabIndex = 1
        '
        'GroupBox62
        '
        Me.GroupBox62.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox62.Controls.Add(Me.cbIngresoCreditoCostoVariable)
        Me.GroupBox62.Controls.Add(Me.cbIngresoCreditoCostoConcepto)
        Me.GroupBox62.Controls.Add(Me.txtCuentaCostoCred)
        Me.GroupBox62.Controls.Add(Me.txtNombreCostoCred)
        Me.GroupBox62.Controls.Add(Me.Button44)
        Me.GroupBox62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox62.Location = New System.Drawing.Point(520, 52)
        Me.GroupBox62.Name = "GroupBox62"
        Me.GroupBox62.Size = New System.Drawing.Size(464, 103)
        Me.GroupBox62.TabIndex = 49
        Me.GroupBox62.TabStop = False
        Me.GroupBox62.Text = "COSTO DE VENTA"
        '
        'cbIngresoCreditoCostoVariable
        '
        Me.cbIngresoCreditoCostoVariable.ItemHeight = 13
        Me.cbIngresoCreditoCostoVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbIngresoCreditoCostoVariable.Name = "cbIngresoCreditoCostoVariable"
        Me.cbIngresoCreditoCostoVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIngresoCreditoCostoVariable.TabIndex = 102
        '
        'cbIngresoCreditoCostoConcepto
        '
        Me.cbIngresoCreditoCostoConcepto.ItemHeight = 13
        Me.cbIngresoCreditoCostoConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIngresoCreditoCostoConcepto.Name = "cbIngresoCreditoCostoConcepto"
        Me.cbIngresoCreditoCostoConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIngresoCreditoCostoConcepto.TabIndex = 101
        '
        'txtCuentaCostoCred
        '
        Me.txtCuentaCostoCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCostoCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaCostoCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCostoCred.Location = New System.Drawing.Point(8, 26)
        Me.txtCuentaCostoCred.Name = "txtCuentaCostoCred"
        Me.txtCuentaCostoCred.ReadOnly = True
        Me.txtCuentaCostoCred.Size = New System.Drawing.Size(112, 20)
        Me.txtCuentaCostoCred.TabIndex = 100
        '
        'txtNombreCostoCred
        '
        Me.txtNombreCostoCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCostoCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCostoCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCostoCred.Location = New System.Drawing.Point(136, 26)
        Me.txtNombreCostoCred.Name = "txtNombreCostoCred"
        Me.txtNombreCostoCred.ReadOnly = True
        Me.txtNombreCostoCred.Size = New System.Drawing.Size(272, 20)
        Me.txtNombreCostoCred.TabIndex = 100
        '
        'Button44
        '
        Me.Button44.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button44.Appearance.Options.UseFont = True
        Me.Button44.Appearance.Options.UseForeColor = True
        Me.Button44.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button44.Image = CType(resources.GetObject("Button44.Image"), System.Drawing.Image)
        Me.Button44.Location = New System.Drawing.Point(416, 17)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(32, 35)
        Me.Button44.TabIndex = 1
        '
        'GroupBox17
        '
        Me.GroupBox17.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox17.Controls.Add(Me.txtIVACred)
        Me.GroupBox17.Controls.Add(Me.txtIVACredNombre)
        Me.GroupBox17.Controls.Add(Me.Button9)
        Me.GroupBox17.Controls.Add(Me.cbIvaCreditoVariable)
        Me.GroupBox17.Controls.Add(Me.cbIvaCreditoConcepto)
        Me.GroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox17.Location = New System.Drawing.Point(32, 172)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox17.TabIndex = 45
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "I.V.A."
        '
        'txtIVACred
        '
        Me.txtIVACred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVACred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVACred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACred.Location = New System.Drawing.Point(8, 26)
        Me.txtIVACred.Name = "txtIVACred"
        Me.txtIVACred.ReadOnly = True
        Me.txtIVACred.Size = New System.Drawing.Size(112, 20)
        Me.txtIVACred.TabIndex = 100
        '
        'txtIVACredNombre
        '
        Me.txtIVACredNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVACredNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVACredNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACredNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIVACredNombre.Name = "txtIVACredNombre"
        Me.txtIVACredNombre.ReadOnly = True
        Me.txtIVACredNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIVACredNombre.TabIndex = 100
        '
        'Button9
        '
        Me.Button9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button9.Appearance.Options.UseFont = True
        Me.Button9.Appearance.Options.UseForeColor = True
        Me.Button9.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(416, 17)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 35)
        Me.Button9.TabIndex = 1
        '
        'cbIvaCreditoVariable
        '
        Me.cbIvaCreditoVariable.ItemHeight = 13
        Me.cbIvaCreditoVariable.Location = New System.Drawing.Point(264, 60)
        Me.cbIvaCreditoVariable.Name = "cbIvaCreditoVariable"
        Me.cbIvaCreditoVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIvaCreditoVariable.TabIndex = 104
        '
        'cbIvaCreditoConcepto
        '
        Me.cbIvaCreditoConcepto.ItemHeight = 13
        Me.cbIvaCreditoConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIvaCreditoConcepto.Name = "cbIvaCreditoConcepto"
        Me.cbIvaCreditoConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIvaCreditoConcepto.TabIndex = 103
        '
        'GroupBox18
        '
        Me.GroupBox18.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox18.Controls.Add(Me.cbIngresoCreditoVariable)
        Me.GroupBox18.Controls.Add(Me.cbIngresoCreditoConcepto)
        Me.GroupBox18.Controls.Add(Me.txtCuentaCred)
        Me.GroupBox18.Controls.Add(Me.txtNombreCred)
        Me.GroupBox18.Controls.Add(Me.Button10)
        Me.GroupBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox18.Location = New System.Drawing.Point(32, 52)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(464, 103)
        Me.GroupBox18.TabIndex = 44
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "CUENTA DE INGRESOS"
        '
        'cbIngresoCreditoVariable
        '
        Me.cbIngresoCreditoVariable.ItemHeight = 13
        Me.cbIngresoCreditoVariable.Location = New System.Drawing.Point(264, 60)
        Me.cbIngresoCreditoVariable.Name = "cbIngresoCreditoVariable"
        Me.cbIngresoCreditoVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIngresoCreditoVariable.TabIndex = 104
        '
        'cbIngresoCreditoConcepto
        '
        Me.cbIngresoCreditoConcepto.ItemHeight = 13
        Me.cbIngresoCreditoConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIngresoCreditoConcepto.Name = "cbIngresoCreditoConcepto"
        Me.cbIngresoCreditoConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIngresoCreditoConcepto.TabIndex = 103
        '
        'txtCuentaCred
        '
        Me.txtCuentaCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCred.Location = New System.Drawing.Point(8, 26)
        Me.txtCuentaCred.Name = "txtCuentaCred"
        Me.txtCuentaCred.ReadOnly = True
        Me.txtCuentaCred.Size = New System.Drawing.Size(112, 20)
        Me.txtCuentaCred.TabIndex = 100
        '
        'txtNombreCred
        '
        Me.txtNombreCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCred.Location = New System.Drawing.Point(128, 26)
        Me.txtNombreCred.Name = "txtNombreCred"
        Me.txtNombreCred.ReadOnly = True
        Me.txtNombreCred.Size = New System.Drawing.Size(272, 20)
        Me.txtNombreCred.TabIndex = 100
        '
        'Button10
        '
        Me.Button10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button10.Appearance.Options.UseFont = True
        Me.Button10.Appearance.Options.UseForeColor = True
        Me.Button10.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(416, 17)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(32, 35)
        Me.Button10.TabIndex = 1
        '
        'gbxIVA
        '
        Me.gbxIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbxIVA.Controls.Add(Me.GroupBox24)
        Me.gbxIVA.Controls.Add(Me.GroupBox19)
        Me.gbxIVA.Controls.Add(Me.GroupBox20)
        Me.gbxIVA.Location = New System.Drawing.Point(8, 116)
        Me.gbxIVA.Name = "gbxIVA"
        Me.gbxIVA.Size = New System.Drawing.Size(1000, 310)
        Me.gbxIVA.TabIndex = 13
        Me.gbxIVA.TabStop = False
        Me.gbxIVA.Visible = False
        '
        'GroupBox24
        '
        Me.GroupBox24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox24.Controls.Add(Me.txtCajaIVA)
        Me.GroupBox24.Controls.Add(Me.txtCajaIVANombre)
        Me.GroupBox24.Controls.Add(Me.Button17)
        Me.GroupBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox24.Location = New System.Drawing.Point(280, 121)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox24.TabIndex = 46
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "CAJA"
        '
        'txtCajaIVA
        '
        Me.txtCajaIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaIVA.Location = New System.Drawing.Point(8, 26)
        Me.txtCajaIVA.Name = "txtCajaIVA"
        Me.txtCajaIVA.ReadOnly = True
        Me.txtCajaIVA.Size = New System.Drawing.Size(112, 20)
        Me.txtCajaIVA.TabIndex = 100
        '
        'txtCajaIVANombre
        '
        Me.txtCajaIVANombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaIVANombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaIVANombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaIVANombre.Location = New System.Drawing.Point(136, 26)
        Me.txtCajaIVANombre.Name = "txtCajaIVANombre"
        Me.txtCajaIVANombre.ReadOnly = True
        Me.txtCajaIVANombre.Size = New System.Drawing.Size(272, 20)
        Me.txtCajaIVANombre.TabIndex = 100
        '
        'Button17
        '
        Me.Button17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button17.Appearance.Options.UseFont = True
        Me.Button17.Appearance.Options.UseForeColor = True
        Me.Button17.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.Location = New System.Drawing.Point(416, 17)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(32, 35)
        Me.Button17.TabIndex = 1
        '
        'GroupBox19
        '
        Me.GroupBox19.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox19.Controls.Add(Me.txtIVAReper)
        Me.GroupBox19.Controls.Add(Me.txtIVAReperNombre)
        Me.GroupBox19.Controls.Add(Me.Button11)
        Me.GroupBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox19.Location = New System.Drawing.Point(520, 26)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox19.TabIndex = 45
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "I.V.A. REPERCUTIDO"
        '
        'txtIVAReper
        '
        Me.txtIVAReper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAReper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVAReper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAReper.Location = New System.Drawing.Point(8, 26)
        Me.txtIVAReper.Name = "txtIVAReper"
        Me.txtIVAReper.ReadOnly = True
        Me.txtIVAReper.Size = New System.Drawing.Size(112, 20)
        Me.txtIVAReper.TabIndex = 100
        '
        'txtIVAReperNombre
        '
        Me.txtIVAReperNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAReperNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVAReperNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAReperNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIVAReperNombre.Name = "txtIVAReperNombre"
        Me.txtIVAReperNombre.ReadOnly = True
        Me.txtIVAReperNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIVAReperNombre.TabIndex = 100
        '
        'Button11
        '
        Me.Button11.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button11.Appearance.Options.UseFont = True
        Me.Button11.Appearance.Options.UseForeColor = True
        Me.Button11.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(416, 17)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(32, 35)
        Me.Button11.TabIndex = 1
        '
        'GroupBox20
        '
        Me.GroupBox20.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox20.Controls.Add(Me.txtIVASoport)
        Me.GroupBox20.Controls.Add(Me.txtIVASoportNombre)
        Me.GroupBox20.Controls.Add(Me.Button12)
        Me.GroupBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox20.Location = New System.Drawing.Point(24, 26)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox20.TabIndex = 44
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "I.V.A. SOPORTADO"
        '
        'txtIVASoport
        '
        Me.txtIVASoport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVASoport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVASoport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVASoport.Location = New System.Drawing.Point(8, 26)
        Me.txtIVASoport.Name = "txtIVASoport"
        Me.txtIVASoport.ReadOnly = True
        Me.txtIVASoport.Size = New System.Drawing.Size(112, 20)
        Me.txtIVASoport.TabIndex = 100
        '
        'txtIVASoportNombre
        '
        Me.txtIVASoportNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVASoportNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIVASoportNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVASoportNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIVASoportNombre.Name = "txtIVASoportNombre"
        Me.txtIVASoportNombre.ReadOnly = True
        Me.txtIVASoportNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIVASoportNombre.TabIndex = 100
        '
        'Button12
        '
        Me.Button12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button12.Appearance.Options.UseFont = True
        Me.Button12.Appearance.Options.UseForeColor = True
        Me.Button12.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.Location = New System.Drawing.Point(416, 17)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(32, 35)
        Me.Button12.TabIndex = 1
        '
        'gbxIR
        '
        Me.gbxIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbxIR.Controls.Add(Me.GroupBox23)
        Me.gbxIR.Controls.Add(Me.GroupBox16)
        Me.gbxIR.Controls.Add(Me.GroupBox21)
        Me.gbxIR.Controls.Add(Me.GroupBox22)
        Me.gbxIR.Controls.Add(Me.GroupBox43)
        Me.gbxIR.Location = New System.Drawing.Point(8, 116)
        Me.gbxIR.Name = "gbxIR"
        Me.gbxIR.Size = New System.Drawing.Size(1000, 310)
        Me.gbxIR.TabIndex = 47
        Me.gbxIR.TabStop = False
        Me.gbxIR.Visible = False
        '
        'GroupBox23
        '
        Me.GroupBox23.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox23.Controls.Add(Me.txtCajaIR)
        Me.GroupBox23.Controls.Add(Me.txtCajaIRNombre)
        Me.GroupBox23.Controls.Add(Me.Button16)
        Me.GroupBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox23.Location = New System.Drawing.Point(24, 164)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox23.TabIndex = 47
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "CAJA"
        '
        'txtCajaIR
        '
        Me.txtCajaIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaIR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaIR.Location = New System.Drawing.Point(8, 26)
        Me.txtCajaIR.Name = "txtCajaIR"
        Me.txtCajaIR.ReadOnly = True
        Me.txtCajaIR.Size = New System.Drawing.Size(112, 20)
        Me.txtCajaIR.TabIndex = 100
        '
        'txtCajaIRNombre
        '
        Me.txtCajaIRNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaIRNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaIRNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaIRNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtCajaIRNombre.Name = "txtCajaIRNombre"
        Me.txtCajaIRNombre.ReadOnly = True
        Me.txtCajaIRNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtCajaIRNombre.TabIndex = 100
        '
        'Button16
        '
        Me.Button16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button16.Appearance.Options.UseFont = True
        Me.Button16.Appearance.Options.UseForeColor = True
        Me.Button16.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.Location = New System.Drawing.Point(416, 17)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(32, 35)
        Me.Button16.TabIndex = 1
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox16.Controls.Add(Me.txtIRPagServ)
        Me.GroupBox16.Controls.Add(Me.txtIRPagServNombre)
        Me.GroupBox16.Controls.Add(Me.Button15)
        Me.GroupBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox16.Location = New System.Drawing.Point(504, 164)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox16.TabIndex = 46
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "I.R.  PAGADO POR ANTICIPADO POR SERVICIOS"
        '
        'txtIRPagServ
        '
        Me.txtIRPagServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagServ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPagServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPagServ.Location = New System.Drawing.Point(8, 26)
        Me.txtIRPagServ.Name = "txtIRPagServ"
        Me.txtIRPagServ.ReadOnly = True
        Me.txtIRPagServ.Size = New System.Drawing.Size(112, 20)
        Me.txtIRPagServ.TabIndex = 100
        '
        'txtIRPagServNombre
        '
        Me.txtIRPagServNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagServNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPagServNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPagServNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRPagServNombre.Name = "txtIRPagServNombre"
        Me.txtIRPagServNombre.ReadOnly = True
        Me.txtIRPagServNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRPagServNombre.TabIndex = 100
        '
        'Button15
        '
        Me.Button15.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button15.Appearance.Options.UseFont = True
        Me.Button15.Appearance.Options.UseForeColor = True
        Me.Button15.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(416, 17)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(32, 35)
        Me.Button15.TabIndex = 1
        '
        'GroupBox21
        '
        Me.GroupBox21.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox21.Controls.Add(Me.txtIRPag)
        Me.GroupBox21.Controls.Add(Me.txtIRPagNombre)
        Me.GroupBox21.Controls.Add(Me.Button13)
        Me.GroupBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox21.Location = New System.Drawing.Point(504, 34)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox21.TabIndex = 45
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "I.R.  PAGADO POR ANTICIPADO POR BIENES"
        '
        'txtIRPag
        '
        Me.txtIRPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPag.Location = New System.Drawing.Point(8, 26)
        Me.txtIRPag.Name = "txtIRPag"
        Me.txtIRPag.ReadOnly = True
        Me.txtIRPag.Size = New System.Drawing.Size(112, 20)
        Me.txtIRPag.TabIndex = 100
        '
        'txtIRPagNombre
        '
        Me.txtIRPagNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPagNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPagNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRPagNombre.Name = "txtIRPagNombre"
        Me.txtIRPagNombre.ReadOnly = True
        Me.txtIRPagNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRPagNombre.TabIndex = 100
        '
        'Button13
        '
        Me.Button13.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button13.Appearance.Options.UseFont = True
        Me.Button13.Appearance.Options.UseForeColor = True
        Me.Button13.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.Location = New System.Drawing.Point(416, 17)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 35)
        Me.Button13.TabIndex = 1
        '
        'GroupBox22
        '
        Me.GroupBox22.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox22.Controls.Add(Me.txtIRVent)
        Me.GroupBox22.Controls.Add(Me.txtIRVentNombre)
        Me.GroupBox22.Controls.Add(Me.Button14)
        Me.GroupBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox22.Location = New System.Drawing.Point(24, 34)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox22.TabIndex = 44
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "I.R. SOBRE VENTAS"
        '
        'txtIRVent
        '
        Me.txtIRVent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRVent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRVent.Location = New System.Drawing.Point(8, 26)
        Me.txtIRVent.Name = "txtIRVent"
        Me.txtIRVent.ReadOnly = True
        Me.txtIRVent.Size = New System.Drawing.Size(112, 20)
        Me.txtIRVent.TabIndex = 100
        '
        'txtIRVentNombre
        '
        Me.txtIRVentNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRVentNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRVentNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRVentNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIRVentNombre.Name = "txtIRVentNombre"
        Me.txtIRVentNombre.ReadOnly = True
        Me.txtIRVentNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRVentNombre.TabIndex = 100
        '
        'Button14
        '
        Me.Button14.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button14.Appearance.Options.UseFont = True
        Me.Button14.Appearance.Options.UseForeColor = True
        Me.Button14.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(416, 17)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(32, 35)
        Me.Button14.TabIndex = 1
        '
        'GroupBox43
        '
        Me.GroupBox43.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox43.Controls.Add(Me.GroupBox48)
        Me.GroupBox43.Controls.Add(Me.GroupBox49)
        Me.GroupBox43.Controls.Add(Me.GroupBox50)
        Me.GroupBox43.Controls.Add(Me.GroupBox51)
        Me.GroupBox43.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox43.Name = "GroupBox43"
        Me.GroupBox43.Size = New System.Drawing.Size(1000, 370)
        Me.GroupBox43.TabIndex = 48
        Me.GroupBox43.TabStop = False
        Me.GroupBox43.Visible = False
        '
        'GroupBox48
        '
        Me.GroupBox48.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox48.Controls.Add(Me.TextBox1)
        Me.GroupBox48.Controls.Add(Me.TextBox2)
        Me.GroupBox48.Controls.Add(Me.Button31)
        Me.GroupBox48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox48.Location = New System.Drawing.Point(24, 164)
        Me.GroupBox48.Name = "GroupBox48"
        Me.GroupBox48.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox48.TabIndex = 47
        Me.GroupBox48.TabStop = False
        Me.GroupBox48.Text = "CAJA"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 100
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(128, 26)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 100
        '
        'Button31
        '
        Me.Button31.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button31.Appearance.Options.UseFont = True
        Me.Button31.Appearance.Options.UseForeColor = True
        Me.Button31.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button31.Location = New System.Drawing.Point(416, 17)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(32, 35)
        Me.Button31.TabIndex = 1
        '
        'GroupBox49
        '
        Me.GroupBox49.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox49.Controls.Add(Me.TextBox3)
        Me.GroupBox49.Controls.Add(Me.TextBox4)
        Me.GroupBox49.Controls.Add(Me.Button32)
        Me.GroupBox49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox49.Location = New System.Drawing.Point(504, 164)
        Me.GroupBox49.Name = "GroupBox49"
        Me.GroupBox49.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox49.TabIndex = 46
        Me.GroupBox49.TabStop = False
        Me.GroupBox49.Text = "I.R.  PAGADO POR ANTICIPADO POR SERVICIOS"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(8, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(112, 20)
        Me.TextBox3.TabIndex = 100
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(136, 26)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(272, 20)
        Me.TextBox4.TabIndex = 100
        '
        'Button32
        '
        Me.Button32.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button32.Appearance.Options.UseFont = True
        Me.Button32.Appearance.Options.UseForeColor = True
        Me.Button32.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button32.Location = New System.Drawing.Point(416, 17)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(32, 35)
        Me.Button32.TabIndex = 1
        '
        'GroupBox50
        '
        Me.GroupBox50.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox50.Controls.Add(Me.TextBox7)
        Me.GroupBox50.Controls.Add(Me.TextBox8)
        Me.GroupBox50.Controls.Add(Me.Button33)
        Me.GroupBox50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox50.Location = New System.Drawing.Point(504, 34)
        Me.GroupBox50.Name = "GroupBox50"
        Me.GroupBox50.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox50.TabIndex = 45
        Me.GroupBox50.TabStop = False
        Me.GroupBox50.Text = "I.R.  PAGADO POR ANTICIPADO POR BIENES"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(8, 26)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(112, 20)
        Me.TextBox7.TabIndex = 100
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(136, 26)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(272, 20)
        Me.TextBox8.TabIndex = 100
        '
        'Button33
        '
        Me.Button33.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button33.Appearance.Options.UseFont = True
        Me.Button33.Appearance.Options.UseForeColor = True
        Me.Button33.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button33.Location = New System.Drawing.Point(416, 17)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(32, 35)
        Me.Button33.TabIndex = 1
        '
        'GroupBox51
        '
        Me.GroupBox51.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox51.Controls.Add(Me.TextBox9)
        Me.GroupBox51.Controls.Add(Me.TextBox10)
        Me.GroupBox51.Controls.Add(Me.Button34)
        Me.GroupBox51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox51.Location = New System.Drawing.Point(24, 34)
        Me.GroupBox51.Name = "GroupBox51"
        Me.GroupBox51.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox51.TabIndex = 44
        Me.GroupBox51.TabStop = False
        Me.GroupBox51.Text = "I.R. SOBRE VENTAS"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(8, 26)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(112, 20)
        Me.TextBox9.TabIndex = 100
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(128, 26)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(272, 20)
        Me.TextBox10.TabIndex = 100
        '
        'Button34
        '
        Me.Button34.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button34.Appearance.Options.UseFont = True
        Me.Button34.Appearance.Options.UseForeColor = True
        Me.Button34.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button34.Location = New System.Drawing.Point(416, 17)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(32, 35)
        Me.Button34.TabIndex = 1
        '
        'gbReciboCaja
        '
        Me.gbReciboCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbReciboCaja.Controls.Add(Me.GroupBox30)
        Me.gbReciboCaja.Controls.Add(Me.GroupBox29)
        Me.gbReciboCaja.Controls.Add(Me.GroupBox28)
        Me.gbReciboCaja.Location = New System.Drawing.Point(8, 116)
        Me.gbReciboCaja.Name = "gbReciboCaja"
        Me.gbReciboCaja.Size = New System.Drawing.Size(1000, 439)
        Me.gbReciboCaja.TabIndex = 48
        Me.gbReciboCaja.TabStop = False
        Me.gbReciboCaja.Visible = False
        '
        'GroupBox30
        '
        Me.GroupBox30.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox30.Controls.Add(Me.cbReciboIvaVariable)
        Me.GroupBox30.Controls.Add(Me.cbReciboIvaConcepto)
        Me.GroupBox30.Controls.Add(Me.txtReciboIvaCuenta)
        Me.GroupBox30.Controls.Add(Me.txtReciboIvaNombre)
        Me.GroupBox30.Controls.Add(Me.Button22)
        Me.GroupBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox30.Location = New System.Drawing.Point(256, 138)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(464, 103)
        Me.GroupBox30.TabIndex = 46
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "IR sobre Ventas - ALCALDIA"
        '
        'cbReciboIvaVariable
        '
        Me.cbReciboIvaVariable.ItemHeight = 13
        Me.cbReciboIvaVariable.Location = New System.Drawing.Point(264, 60)
        Me.cbReciboIvaVariable.Name = "cbReciboIvaVariable"
        Me.cbReciboIvaVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbReciboIvaVariable.TabIndex = 104
        '
        'cbReciboIvaConcepto
        '
        Me.cbReciboIvaConcepto.ItemHeight = 13
        Me.cbReciboIvaConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbReciboIvaConcepto.Name = "cbReciboIvaConcepto"
        Me.cbReciboIvaConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbReciboIvaConcepto.TabIndex = 103
        '
        'txtReciboIvaCuenta
        '
        Me.txtReciboIvaCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReciboIvaCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReciboIvaCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboIvaCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtReciboIvaCuenta.Name = "txtReciboIvaCuenta"
        Me.txtReciboIvaCuenta.ReadOnly = True
        Me.txtReciboIvaCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtReciboIvaCuenta.TabIndex = 100
        '
        'txtReciboIvaNombre
        '
        Me.txtReciboIvaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReciboIvaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReciboIvaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboIvaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtReciboIvaNombre.Name = "txtReciboIvaNombre"
        Me.txtReciboIvaNombre.ReadOnly = True
        Me.txtReciboIvaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtReciboIvaNombre.TabIndex = 100
        '
        'Button22
        '
        Me.Button22.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button22.Appearance.Options.UseFont = True
        Me.Button22.Appearance.Options.UseForeColor = True
        Me.Button22.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.Location = New System.Drawing.Point(416, 17)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(32, 35)
        Me.Button22.TabIndex = 1
        '
        'GroupBox29
        '
        Me.GroupBox29.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox29.Controls.Add(Me.cbReciboIRVariable)
        Me.GroupBox29.Controls.Add(Me.cbReciboIRConcepto)
        Me.GroupBox29.Controls.Add(Me.txtReciboIRCuenta)
        Me.GroupBox29.Controls.Add(Me.txtReciboIRNombre)
        Me.GroupBox29.Controls.Add(Me.Button21)
        Me.GroupBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox29.Location = New System.Drawing.Point(512, 17)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(464, 104)
        Me.GroupBox29.TabIndex = 45
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "I.R"
        '
        'cbReciboIRVariable
        '
        Me.cbReciboIRVariable.ItemHeight = 13
        Me.cbReciboIRVariable.Location = New System.Drawing.Point(264, 60)
        Me.cbReciboIRVariable.Name = "cbReciboIRVariable"
        Me.cbReciboIRVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbReciboIRVariable.TabIndex = 104
        '
        'cbReciboIRConcepto
        '
        Me.cbReciboIRConcepto.ItemHeight = 13
        Me.cbReciboIRConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbReciboIRConcepto.Name = "cbReciboIRConcepto"
        Me.cbReciboIRConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbReciboIRConcepto.TabIndex = 103
        '
        'txtReciboIRCuenta
        '
        Me.txtReciboIRCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReciboIRCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReciboIRCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboIRCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtReciboIRCuenta.Name = "txtReciboIRCuenta"
        Me.txtReciboIRCuenta.ReadOnly = True
        Me.txtReciboIRCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtReciboIRCuenta.TabIndex = 100
        '
        'txtReciboIRNombre
        '
        Me.txtReciboIRNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReciboIRNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReciboIRNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboIRNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtReciboIRNombre.Name = "txtReciboIRNombre"
        Me.txtReciboIRNombre.ReadOnly = True
        Me.txtReciboIRNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtReciboIRNombre.TabIndex = 100
        '
        'Button21
        '
        Me.Button21.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button21.Appearance.Options.UseFont = True
        Me.Button21.Appearance.Options.UseForeColor = True
        Me.Button21.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
        Me.Button21.Location = New System.Drawing.Point(416, 17)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(32, 35)
        Me.Button21.TabIndex = 1
        '
        'GroupBox28
        '
        Me.GroupBox28.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox28.Controls.Add(Me.cbCajaVariable1)
        Me.GroupBox28.Controls.Add(Me.cbCajaConcepto1)
        Me.GroupBox28.Controls.Add(Me.txtCajaCodigo)
        Me.GroupBox28.Controls.Add(Me.txtCajaNombre)
        Me.GroupBox28.Controls.Add(Me.Button19)
        Me.GroupBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox28.Location = New System.Drawing.Point(24, 17)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(464, 104)
        Me.GroupBox28.TabIndex = 44
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "CAJA"
        '
        'cbCajaVariable1
        '
        Me.cbCajaVariable1.ItemHeight = 13
        Me.cbCajaVariable1.Location = New System.Drawing.Point(264, 60)
        Me.cbCajaVariable1.Name = "cbCajaVariable1"
        Me.cbCajaVariable1.Size = New System.Drawing.Size(184, 21)
        Me.cbCajaVariable1.TabIndex = 104
        '
        'cbCajaConcepto1
        '
        Me.cbCajaConcepto1.ItemHeight = 13
        Me.cbCajaConcepto1.Location = New System.Drawing.Point(8, 60)
        Me.cbCajaConcepto1.Name = "cbCajaConcepto1"
        Me.cbCajaConcepto1.Size = New System.Drawing.Size(248, 21)
        Me.cbCajaConcepto1.TabIndex = 103
        '
        'txtCajaCodigo
        '
        Me.txtCajaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtCajaCodigo.Name = "txtCajaCodigo"
        Me.txtCajaCodigo.ReadOnly = True
        Me.txtCajaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCajaCodigo.TabIndex = 100
        '
        'txtCajaNombre
        '
        Me.txtCajaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtCajaNombre.Name = "txtCajaNombre"
        Me.txtCajaNombre.ReadOnly = True
        Me.txtCajaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtCajaNombre.TabIndex = 100
        '
        'Button19
        '
        Me.Button19.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button19.Appearance.Options.UseFont = True
        Me.Button19.Appearance.Options.UseForeColor = True
        Me.Button19.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button19.Image = CType(resources.GetObject("Button19.Image"), System.Drawing.Image)
        Me.Button19.Location = New System.Drawing.Point(416, 17)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(32, 35)
        Me.Button19.TabIndex = 1
        '
        'GroupBox26
        '
        Me.GroupBox26.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox26.Controls.Add(Me.cbMoneda1Variable)
        Me.GroupBox26.Controls.Add(Me.cbMoneda1Concepto)
        Me.GroupBox26.Controls.Add(Me.txtMoneda1Cuenta)
        Me.GroupBox26.Controls.Add(Me.txtMoneda1Nombre)
        Me.GroupBox26.Controls.Add(Me.Button18)
        Me.GroupBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox26.Location = New System.Drawing.Point(520, 17)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox26.TabIndex = 44
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "MONEDA NACIONAL"
        '
        'cbMoneda1Variable
        '
        Me.cbMoneda1Variable.ItemHeight = 13
        Me.cbMoneda1Variable.Location = New System.Drawing.Point(268, 58)
        Me.cbMoneda1Variable.Name = "cbMoneda1Variable"
        Me.cbMoneda1Variable.Size = New System.Drawing.Size(184, 21)
        Me.cbMoneda1Variable.TabIndex = 102
        Me.cbMoneda1Variable.Visible = False
        '
        'cbMoneda1Concepto
        '
        Me.cbMoneda1Concepto.ItemHeight = 13
        Me.cbMoneda1Concepto.Location = New System.Drawing.Point(12, 58)
        Me.cbMoneda1Concepto.Name = "cbMoneda1Concepto"
        Me.cbMoneda1Concepto.Size = New System.Drawing.Size(248, 21)
        Me.cbMoneda1Concepto.TabIndex = 101
        Me.cbMoneda1Concepto.Visible = False
        '
        'txtMoneda1Cuenta
        '
        Me.txtMoneda1Cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoneda1Cuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoneda1Cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda1Cuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtMoneda1Cuenta.Name = "txtMoneda1Cuenta"
        Me.txtMoneda1Cuenta.ReadOnly = True
        Me.txtMoneda1Cuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtMoneda1Cuenta.TabIndex = 100
        '
        'txtMoneda1Nombre
        '
        Me.txtMoneda1Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoneda1Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoneda1Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda1Nombre.Location = New System.Drawing.Point(128, 26)
        Me.txtMoneda1Nombre.Name = "txtMoneda1Nombre"
        Me.txtMoneda1Nombre.ReadOnly = True
        Me.txtMoneda1Nombre.Size = New System.Drawing.Size(272, 20)
        Me.txtMoneda1Nombre.TabIndex = 100
        '
        'Button18
        '
        Me.Button18.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button18.Appearance.Options.UseFont = True
        Me.Button18.Appearance.Options.UseForeColor = True
        Me.Button18.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.Location = New System.Drawing.Point(416, 17)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(32, 35)
        Me.Button18.TabIndex = 1
        '
        'GroupBox27
        '
        Me.GroupBox27.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox27.Controls.Add(Me.cbMoneda2Variable)
        Me.GroupBox27.Controls.Add(Me.cbMoneda2Concepto)
        Me.GroupBox27.Controls.Add(Me.txtMoneda2Cuenta)
        Me.GroupBox27.Controls.Add(Me.txtMoneda2Nombre)
        Me.GroupBox27.Controls.Add(Me.Button20)
        Me.GroupBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox27.Location = New System.Drawing.Point(264, 138)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox27.TabIndex = 45
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "MONEDA EXTRANJERA"
        '
        'cbMoneda2Variable
        '
        Me.cbMoneda2Variable.ItemHeight = 13
        Me.cbMoneda2Variable.Location = New System.Drawing.Point(268, 58)
        Me.cbMoneda2Variable.Name = "cbMoneda2Variable"
        Me.cbMoneda2Variable.Size = New System.Drawing.Size(184, 21)
        Me.cbMoneda2Variable.TabIndex = 102
        Me.cbMoneda2Variable.Visible = False
        '
        'cbMoneda2Concepto
        '
        Me.cbMoneda2Concepto.ItemHeight = 13
        Me.cbMoneda2Concepto.Location = New System.Drawing.Point(12, 58)
        Me.cbMoneda2Concepto.Name = "cbMoneda2Concepto"
        Me.cbMoneda2Concepto.Size = New System.Drawing.Size(248, 21)
        Me.cbMoneda2Concepto.TabIndex = 101
        Me.cbMoneda2Concepto.Visible = False
        '
        'txtMoneda2Cuenta
        '
        Me.txtMoneda2Cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoneda2Cuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoneda2Cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda2Cuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtMoneda2Cuenta.Name = "txtMoneda2Cuenta"
        Me.txtMoneda2Cuenta.ReadOnly = True
        Me.txtMoneda2Cuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtMoneda2Cuenta.TabIndex = 100
        '
        'txtMoneda2Nombre
        '
        Me.txtMoneda2Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoneda2Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoneda2Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda2Nombre.Location = New System.Drawing.Point(128, 26)
        Me.txtMoneda2Nombre.Name = "txtMoneda2Nombre"
        Me.txtMoneda2Nombre.ReadOnly = True
        Me.txtMoneda2Nombre.Size = New System.Drawing.Size(272, 20)
        Me.txtMoneda2Nombre.TabIndex = 100
        '
        'Button20
        '
        Me.Button20.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button20.Appearance.Options.UseFont = True
        Me.Button20.Appearance.Options.UseForeColor = True
        Me.Button20.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button20.Image = CType(resources.GetObject("Button20.Image"), System.Drawing.Image)
        Me.Button20.Location = New System.Drawing.Point(416, 17)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(32, 35)
        Me.Button20.TabIndex = 1
        '
        'gbDepositoBancario
        '
        Me.gbDepositoBancario.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbDepositoBancario.Controls.Add(Me.GroupBox32)
        Me.gbDepositoBancario.Controls.Add(Me.GroupBox26)
        Me.gbDepositoBancario.Controls.Add(Me.GroupBox27)
        Me.gbDepositoBancario.Location = New System.Drawing.Point(8, 116)
        Me.gbDepositoBancario.Name = "gbDepositoBancario"
        Me.gbDepositoBancario.Size = New System.Drawing.Size(1000, 310)
        Me.gbDepositoBancario.TabIndex = 49
        Me.gbDepositoBancario.TabStop = False
        Me.gbDepositoBancario.Visible = False
        '
        'GroupBox32
        '
        Me.GroupBox32.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox32.Controls.Add(Me.ComboBox5)
        Me.GroupBox32.Controls.Add(Me.ComboBox6)
        Me.GroupBox32.Controls.Add(Me.TextBox5)
        Me.GroupBox32.Controls.Add(Me.TextBox6)
        Me.GroupBox32.Controls.Add(Me.Button23)
        Me.GroupBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox32.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox32.TabIndex = 43
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "CAJA"
        '
        'ComboBox5
        '
        Me.ComboBox5.ItemHeight = 13
        Me.ComboBox5.Location = New System.Drawing.Point(268, 58)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox5.TabIndex = 102
        Me.ComboBox5.Visible = False
        '
        'ComboBox6
        '
        Me.ComboBox6.ItemHeight = 13
        Me.ComboBox6.Location = New System.Drawing.Point(12, 58)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox6.TabIndex = 101
        Me.ComboBox6.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(8, 26)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(112, 20)
        Me.TextBox5.TabIndex = 100
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(128, 26)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(272, 20)
        Me.TextBox6.TabIndex = 100
        '
        'Button23
        '
        Me.Button23.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button23.Appearance.Options.UseFont = True
        Me.Button23.Appearance.Options.UseForeColor = True
        Me.Button23.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button23.Image = CType(resources.GetObject("Button23.Image"), System.Drawing.Image)
        Me.Button23.Location = New System.Drawing.Point(416, 17)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(32, 35)
        Me.Button23.TabIndex = 1
        '
        'gbComprasContado
        '
        Me.gbComprasContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbComprasContado.Controls.Add(Me.GroupBox78)
        Me.gbComprasContado.Controls.Add(Me.gbCCBanco)
        Me.gbComprasContado.Controls.Add(Me.GroupBox33)
        Me.gbComprasContado.Controls.Add(Me.GroupBox34)
        Me.gbComprasContado.Location = New System.Drawing.Point(8, 116)
        Me.gbComprasContado.Name = "gbComprasContado"
        Me.gbComprasContado.Size = New System.Drawing.Size(1000, 439)
        Me.gbComprasContado.TabIndex = 50
        Me.gbComprasContado.TabStop = False
        Me.gbComprasContado.Visible = False
        '
        'GroupBox78
        '
        Me.GroupBox78.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox78.Controls.Add(Me.cbIRCompContVar)
        Me.GroupBox78.Controls.Add(Me.cbIRCompContConcep)
        Me.GroupBox78.Controls.Add(Me.txtIRCompContCuenta)
        Me.GroupBox78.Controls.Add(Me.txtIRCompContNombre)
        Me.GroupBox78.Controls.Add(Me.Button62)
        Me.GroupBox78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox78.Location = New System.Drawing.Point(520, 155)
        Me.GroupBox78.Name = "GroupBox78"
        Me.GroupBox78.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox78.TabIndex = 48
        Me.GroupBox78.TabStop = False
        Me.GroupBox78.Text = "I.R. ALCALDIA"
        '
        'cbIRCompContVar
        '
        Me.cbIRCompContVar.ItemHeight = 13
        Me.cbIRCompContVar.Location = New System.Drawing.Point(268, 60)
        Me.cbIRCompContVar.Name = "cbIRCompContVar"
        Me.cbIRCompContVar.Size = New System.Drawing.Size(184, 21)
        Me.cbIRCompContVar.TabIndex = 102
        '
        'cbIRCompContConcep
        '
        Me.cbIRCompContConcep.ItemHeight = 13
        Me.cbIRCompContConcep.Location = New System.Drawing.Point(8, 60)
        Me.cbIRCompContConcep.Name = "cbIRCompContConcep"
        Me.cbIRCompContConcep.Size = New System.Drawing.Size(248, 21)
        Me.cbIRCompContConcep.TabIndex = 101
        '
        'txtIRCompContCuenta
        '
        Me.txtIRCompContCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCompContCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCompContCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCompContCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtIRCompContCuenta.Name = "txtIRCompContCuenta"
        Me.txtIRCompContCuenta.ReadOnly = True
        Me.txtIRCompContCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIRCompContCuenta.TabIndex = 100
        '
        'txtIRCompContNombre
        '
        Me.txtIRCompContNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCompContNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCompContNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCompContNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRCompContNombre.Name = "txtIRCompContNombre"
        Me.txtIRCompContNombre.ReadOnly = True
        Me.txtIRCompContNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRCompContNombre.TabIndex = 100
        '
        'Button62
        '
        Me.Button62.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button62.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button62.Appearance.Options.UseFont = True
        Me.Button62.Appearance.Options.UseForeColor = True
        Me.Button62.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button62.Image = CType(resources.GetObject("Button62.Image"), System.Drawing.Image)
        Me.Button62.Location = New System.Drawing.Point(416, 17)
        Me.Button62.Name = "Button62"
        Me.Button62.Size = New System.Drawing.Size(32, 35)
        Me.Button62.TabIndex = 1
        '
        'gbCCBanco
        '
        Me.gbCCBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbCCBanco.Controls.Add(Me.cbccVariable)
        Me.gbCCBanco.Controls.Add(Me.cbccConcepto)
        Me.gbCCBanco.Controls.Add(Me.txtccCuenta)
        Me.gbCCBanco.Controls.Add(Me.txtccNombre)
        Me.gbCCBanco.Controls.Add(Me.Button59)
        Me.gbCCBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCCBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbCCBanco.Location = New System.Drawing.Point(40, 155)
        Me.gbCCBanco.Name = "gbCCBanco"
        Me.gbCCBanco.Size = New System.Drawing.Size(464, 112)
        Me.gbCCBanco.TabIndex = 47
        Me.gbCCBanco.TabStop = False
        Me.gbCCBanco.Text = "BANCO"
        '
        'cbccVariable
        '
        Me.cbccVariable.ItemHeight = 13
        Me.cbccVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbccVariable.Name = "cbccVariable"
        Me.cbccVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbccVariable.TabIndex = 102
        '
        'cbccConcepto
        '
        Me.cbccConcepto.ItemHeight = 13
        Me.cbccConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbccConcepto.Name = "cbccConcepto"
        Me.cbccConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbccConcepto.TabIndex = 101
        '
        'txtccCuenta
        '
        Me.txtccCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtccCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtccCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtccCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtccCuenta.Name = "txtccCuenta"
        Me.txtccCuenta.ReadOnly = True
        Me.txtccCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtccCuenta.TabIndex = 100
        '
        'txtccNombre
        '
        Me.txtccNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtccNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtccNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtccNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtccNombre.Name = "txtccNombre"
        Me.txtccNombre.ReadOnly = True
        Me.txtccNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtccNombre.TabIndex = 100
        '
        'Button59
        '
        Me.Button59.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button59.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button59.Appearance.Options.UseFont = True
        Me.Button59.Appearance.Options.UseForeColor = True
        Me.Button59.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button59.Image = CType(resources.GetObject("Button59.Image"), System.Drawing.Image)
        Me.Button59.Location = New System.Drawing.Point(416, 17)
        Me.Button59.Name = "Button59"
        Me.Button59.Size = New System.Drawing.Size(32, 35)
        Me.Button59.TabIndex = 1
        '
        'GroupBox33
        '
        Me.GroupBox33.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox33.Controls.Add(Me.cbIRCCVariable)
        Me.GroupBox33.Controls.Add(Me.cbIRCCConcepto)
        Me.GroupBox33.Controls.Add(Me.txtIRCCCodigo)
        Me.GroupBox33.Controls.Add(Me.txtIRCCNombre)
        Me.GroupBox33.Controls.Add(Me.Button24)
        Me.GroupBox33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox33.Location = New System.Drawing.Point(40, 26)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox33.TabIndex = 46
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "IR"
        '
        'cbIRCCVariable
        '
        Me.cbIRCCVariable.ItemHeight = 13
        Me.cbIRCCVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbIRCCVariable.Name = "cbIRCCVariable"
        Me.cbIRCCVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIRCCVariable.TabIndex = 102
        '
        'cbIRCCConcepto
        '
        Me.cbIRCCConcepto.ItemHeight = 13
        Me.cbIRCCConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIRCCConcepto.Name = "cbIRCCConcepto"
        Me.cbIRCCConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIRCCConcepto.TabIndex = 101
        '
        'txtIRCCCodigo
        '
        Me.txtIRCCCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCCCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCCCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCCCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRCCCodigo.Name = "txtIRCCCodigo"
        Me.txtIRCCCodigo.ReadOnly = True
        Me.txtIRCCCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRCCCodigo.TabIndex = 100
        '
        'txtIRCCNombre
        '
        Me.txtIRCCNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCCNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCCNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCCNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRCCNombre.Name = "txtIRCCNombre"
        Me.txtIRCCNombre.ReadOnly = True
        Me.txtIRCCNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRCCNombre.TabIndex = 100
        '
        'Button24
        '
        Me.Button24.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button24.Appearance.Options.UseFont = True
        Me.Button24.Appearance.Options.UseForeColor = True
        Me.Button24.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button24.Image = CType(resources.GetObject("Button24.Image"), System.Drawing.Image)
        Me.Button24.Location = New System.Drawing.Point(416, 17)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(32, 35)
        Me.Button24.TabIndex = 1
        '
        'GroupBox34
        '
        Me.GroupBox34.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox34.Controls.Add(Me.cbIvaCCVariable)
        Me.GroupBox34.Controls.Add(Me.cbIvaCCConcepto)
        Me.GroupBox34.Controls.Add(Me.txtIvaCCCodigo)
        Me.GroupBox34.Controls.Add(Me.txtIvaCCNombre)
        Me.GroupBox34.Controls.Add(Me.Button25)
        Me.GroupBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox34.Location = New System.Drawing.Point(520, 34)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox34.TabIndex = 45
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "I.V.A."
        '
        'cbIvaCCVariable
        '
        Me.cbIvaCCVariable.ItemHeight = 13
        Me.cbIvaCCVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbIvaCCVariable.Name = "cbIvaCCVariable"
        Me.cbIvaCCVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIvaCCVariable.TabIndex = 102
        '
        'cbIvaCCConcepto
        '
        Me.cbIvaCCConcepto.ItemHeight = 13
        Me.cbIvaCCConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIvaCCConcepto.Name = "cbIvaCCConcepto"
        Me.cbIvaCCConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIvaCCConcepto.TabIndex = 101
        '
        'txtIvaCCCodigo
        '
        Me.txtIvaCCCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaCCCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIvaCCCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaCCCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIvaCCCodigo.Name = "txtIvaCCCodigo"
        Me.txtIvaCCCodigo.ReadOnly = True
        Me.txtIvaCCCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIvaCCCodigo.TabIndex = 100
        '
        'txtIvaCCNombre
        '
        Me.txtIvaCCNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaCCNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIvaCCNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaCCNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIvaCCNombre.Name = "txtIvaCCNombre"
        Me.txtIvaCCNombre.ReadOnly = True
        Me.txtIvaCCNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIvaCCNombre.TabIndex = 100
        '
        'Button25
        '
        Me.Button25.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button25.Appearance.Options.UseFont = True
        Me.Button25.Appearance.Options.UseForeColor = True
        Me.Button25.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button25.Image = CType(resources.GetObject("Button25.Image"), System.Drawing.Image)
        Me.Button25.Location = New System.Drawing.Point(416, 17)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(32, 35)
        Me.Button25.TabIndex = 1
        '
        'gbComprasCredito
        '
        Me.gbComprasCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbComprasCredito.Controls.Add(Me.GroupBox79)
        Me.gbComprasCredito.Controls.Add(Me.GroupBox74)
        Me.gbComprasCredito.Controls.Add(Me.GroupBox36)
        Me.gbComprasCredito.Location = New System.Drawing.Point(8, 116)
        Me.gbComprasCredito.Name = "gbComprasCredito"
        Me.gbComprasCredito.Size = New System.Drawing.Size(1000, 431)
        Me.gbComprasCredito.TabIndex = 51
        Me.gbComprasCredito.TabStop = False
        Me.gbComprasCredito.Visible = False
        '
        'GroupBox79
        '
        Me.GroupBox79.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox79.Controls.Add(Me.cbIRAlcCompCredVar)
        Me.GroupBox79.Controls.Add(Me.cbIRAlcCompCredConcepto)
        Me.GroupBox79.Controls.Add(Me.txtIRAlcCompCredCuenta)
        Me.GroupBox79.Controls.Add(Me.txtIRAlcCompCredNombre)
        Me.GroupBox79.Controls.Add(Me.Button63)
        Me.GroupBox79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox79.Location = New System.Drawing.Point(256, 293)
        Me.GroupBox79.Name = "GroupBox79"
        Me.GroupBox79.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox79.TabIndex = 48
        Me.GroupBox79.TabStop = False
        Me.GroupBox79.Text = "I.R. ALCALDIA"
        '
        'cbIRAlcCompCredVar
        '
        Me.cbIRAlcCompCredVar.ItemHeight = 13
        Me.cbIRAlcCompCredVar.Location = New System.Drawing.Point(268, 60)
        Me.cbIRAlcCompCredVar.Name = "cbIRAlcCompCredVar"
        Me.cbIRAlcCompCredVar.Size = New System.Drawing.Size(184, 21)
        Me.cbIRAlcCompCredVar.TabIndex = 102
        '
        'cbIRAlcCompCredConcepto
        '
        Me.cbIRAlcCompCredConcepto.ItemHeight = 13
        Me.cbIRAlcCompCredConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIRAlcCompCredConcepto.Name = "cbIRAlcCompCredConcepto"
        Me.cbIRAlcCompCredConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIRAlcCompCredConcepto.TabIndex = 101
        '
        'txtIRAlcCompCredCuenta
        '
        Me.txtIRAlcCompCredCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRAlcCompCredCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRAlcCompCredCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRAlcCompCredCuenta.Location = New System.Drawing.Point(8, 26)
        Me.txtIRAlcCompCredCuenta.Name = "txtIRAlcCompCredCuenta"
        Me.txtIRAlcCompCredCuenta.ReadOnly = True
        Me.txtIRAlcCompCredCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIRAlcCompCredCuenta.TabIndex = 100
        '
        'txtIRAlcCompCredNombre
        '
        Me.txtIRAlcCompCredNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRAlcCompCredNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRAlcCompCredNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRAlcCompCredNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRAlcCompCredNombre.Name = "txtIRAlcCompCredNombre"
        Me.txtIRAlcCompCredNombre.ReadOnly = True
        Me.txtIRAlcCompCredNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRAlcCompCredNombre.TabIndex = 100
        '
        'Button63
        '
        Me.Button63.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button63.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button63.Appearance.Options.UseFont = True
        Me.Button63.Appearance.Options.UseForeColor = True
        Me.Button63.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button63.Image = CType(resources.GetObject("Button63.Image"), System.Drawing.Image)
        Me.Button63.Location = New System.Drawing.Point(416, 17)
        Me.Button63.Name = "Button63"
        Me.Button63.Size = New System.Drawing.Size(32, 35)
        Me.Button63.TabIndex = 1
        '
        'GroupBox74
        '
        Me.GroupBox74.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox74.Controls.Add(Me.cbCompraCredVar)
        Me.GroupBox74.Controls.Add(Me.cbCompraCredConcep)
        Me.GroupBox74.Controls.Add(Me.txtIRCompraCredC)
        Me.GroupBox74.Controls.Add(Me.txtIRCompraCredN)
        Me.GroupBox74.Controls.Add(Me.Button58)
        Me.GroupBox74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox74.Location = New System.Drawing.Point(256, 155)
        Me.GroupBox74.Name = "GroupBox74"
        Me.GroupBox74.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox74.TabIndex = 47
        Me.GroupBox74.TabStop = False
        Me.GroupBox74.Text = "IR"
        '
        'cbCompraCredVar
        '
        Me.cbCompraCredVar.ItemHeight = 13
        Me.cbCompraCredVar.Location = New System.Drawing.Point(268, 60)
        Me.cbCompraCredVar.Name = "cbCompraCredVar"
        Me.cbCompraCredVar.Size = New System.Drawing.Size(184, 21)
        Me.cbCompraCredVar.TabIndex = 102
        '
        'cbCompraCredConcep
        '
        Me.cbCompraCredConcep.ItemHeight = 13
        Me.cbCompraCredConcep.Location = New System.Drawing.Point(8, 60)
        Me.cbCompraCredConcep.Name = "cbCompraCredConcep"
        Me.cbCompraCredConcep.Size = New System.Drawing.Size(248, 21)
        Me.cbCompraCredConcep.TabIndex = 101
        '
        'txtIRCompraCredC
        '
        Me.txtIRCompraCredC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCompraCredC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCompraCredC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCompraCredC.Location = New System.Drawing.Point(8, 26)
        Me.txtIRCompraCredC.Name = "txtIRCompraCredC"
        Me.txtIRCompraCredC.ReadOnly = True
        Me.txtIRCompraCredC.Size = New System.Drawing.Size(112, 20)
        Me.txtIRCompraCredC.TabIndex = 100
        '
        'txtIRCompraCredN
        '
        Me.txtIRCompraCredN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRCompraCredN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRCompraCredN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCompraCredN.Location = New System.Drawing.Point(136, 26)
        Me.txtIRCompraCredN.Name = "txtIRCompraCredN"
        Me.txtIRCompraCredN.ReadOnly = True
        Me.txtIRCompraCredN.Size = New System.Drawing.Size(272, 20)
        Me.txtIRCompraCredN.TabIndex = 100
        '
        'Button58
        '
        Me.Button58.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button58.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button58.Appearance.Options.UseFont = True
        Me.Button58.Appearance.Options.UseForeColor = True
        Me.Button58.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button58.Image = CType(resources.GetObject("Button58.Image"), System.Drawing.Image)
        Me.Button58.Location = New System.Drawing.Point(416, 17)
        Me.Button58.Name = "Button58"
        Me.Button58.Size = New System.Drawing.Size(32, 35)
        Me.Button58.TabIndex = 1
        '
        'GroupBox36
        '
        Me.GroupBox36.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox36.Controls.Add(Me.cbIvaCCredVariable)
        Me.GroupBox36.Controls.Add(Me.cbIvaCCredConcepto)
        Me.GroupBox36.Controls.Add(Me.txtIvaCCredCodigo)
        Me.GroupBox36.Controls.Add(Me.txtIvaCCredNombre)
        Me.GroupBox36.Controls.Add(Me.Button27)
        Me.GroupBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox36.Location = New System.Drawing.Point(256, 26)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox36.TabIndex = 45
        Me.GroupBox36.TabStop = False
        Me.GroupBox36.Text = "I.V.A."
        '
        'cbIvaCCredVariable
        '
        Me.cbIvaCCredVariable.ItemHeight = 13
        Me.cbIvaCCredVariable.Location = New System.Drawing.Point(268, 60)
        Me.cbIvaCCredVariable.Name = "cbIvaCCredVariable"
        Me.cbIvaCCredVariable.Size = New System.Drawing.Size(184, 21)
        Me.cbIvaCCredVariable.TabIndex = 102
        '
        'cbIvaCCredConcepto
        '
        Me.cbIvaCCredConcepto.ItemHeight = 13
        Me.cbIvaCCredConcepto.Location = New System.Drawing.Point(8, 60)
        Me.cbIvaCCredConcepto.Name = "cbIvaCCredConcepto"
        Me.cbIvaCCredConcepto.Size = New System.Drawing.Size(248, 21)
        Me.cbIvaCCredConcepto.TabIndex = 101
        '
        'txtIvaCCredCodigo
        '
        Me.txtIvaCCredCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaCCredCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIvaCCredCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaCCredCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIvaCCredCodigo.Name = "txtIvaCCredCodigo"
        Me.txtIvaCCredCodigo.ReadOnly = True
        Me.txtIvaCCredCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIvaCCredCodigo.TabIndex = 100
        '
        'txtIvaCCredNombre
        '
        Me.txtIvaCCredNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaCCredNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIvaCCredNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaCCredNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIvaCCredNombre.Name = "txtIvaCCredNombre"
        Me.txtIvaCCredNombre.ReadOnly = True
        Me.txtIvaCCredNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIvaCCredNombre.TabIndex = 100
        '
        'Button27
        '
        Me.Button27.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button27.Appearance.Options.UseFont = True
        Me.Button27.Appearance.Options.UseForeColor = True
        Me.Button27.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button27.Image = CType(resources.GetObject("Button27.Image"), System.Drawing.Image)
        Me.Button27.Location = New System.Drawing.Point(416, 17)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(32, 35)
        Me.Button27.TabIndex = 1
        '
        'gbImpuestos
        '
        Me.gbImpuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbImpuestos.Controls.Add(Me.GroupBox42)
        Me.gbImpuestos.Controls.Add(Me.GroupBox40)
        Me.gbImpuestos.Controls.Add(Me.GroupBox41)
        Me.gbImpuestos.Controls.Add(Me.GroupBox31)
        Me.gbImpuestos.Controls.Add(Me.GroupBox35)
        Me.gbImpuestos.Controls.Add(Me.GroupBox37)
        Me.gbImpuestos.Controls.Add(Me.GroupBox38)
        Me.gbImpuestos.Controls.Add(Me.GroupBox39)
        Me.gbImpuestos.Location = New System.Drawing.Point(8, 116)
        Me.gbImpuestos.Name = "gbImpuestos"
        Me.gbImpuestos.Size = New System.Drawing.Size(1000, 310)
        Me.gbImpuestos.TabIndex = 52
        Me.gbImpuestos.TabStop = False
        Me.gbImpuestos.Visible = False
        '
        'GroupBox42
        '
        Me.GroupBox42.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox42.Controls.Add(Me.txtCajaImpCodigo)
        Me.GroupBox42.Controls.Add(Me.txtCajaImpNombre)
        Me.GroupBox42.Controls.Add(Me.cmdCajaImp)
        Me.GroupBox42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox42.Location = New System.Drawing.Point(496, 155)
        Me.GroupBox42.Name = "GroupBox42"
        Me.GroupBox42.Size = New System.Drawing.Size(464, 60)
        Me.GroupBox42.TabIndex = 51
        Me.GroupBox42.TabStop = False
        Me.GroupBox42.Text = "CAJA GENERAL"
        '
        'txtCajaImpCodigo
        '
        Me.txtCajaImpCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaImpCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaImpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaImpCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtCajaImpCodigo.Name = "txtCajaImpCodigo"
        Me.txtCajaImpCodigo.ReadOnly = True
        Me.txtCajaImpCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCajaImpCodigo.TabIndex = 100
        '
        'txtCajaImpNombre
        '
        Me.txtCajaImpNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajaImpNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCajaImpNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaImpNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtCajaImpNombre.Name = "txtCajaImpNombre"
        Me.txtCajaImpNombre.ReadOnly = True
        Me.txtCajaImpNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtCajaImpNombre.TabIndex = 100
        '
        'cmdCajaImp
        '
        Me.cmdCajaImp.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCajaImp.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdCajaImp.Appearance.Options.UseFont = True
        Me.cmdCajaImp.Appearance.Options.UseForeColor = True
        Me.cmdCajaImp.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdCajaImp.Image = CType(resources.GetObject("cmdCajaImp.Image"), System.Drawing.Image)
        Me.cmdCajaImp.Location = New System.Drawing.Point(416, 17)
        Me.cmdCajaImp.Name = "cmdCajaImp"
        Me.cmdCajaImp.Size = New System.Drawing.Size(32, 35)
        Me.cmdCajaImp.TabIndex = 1
        '
        'GroupBox40
        '
        Me.GroupBox40.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox40.Controls.Add(Me.txtIva2Codigo)
        Me.GroupBox40.Controls.Add(Me.txtIva2Nombre)
        Me.GroupBox40.Controls.Add(Me.cmdIva2)
        Me.GroupBox40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox40.Location = New System.Drawing.Point(496, 86)
        Me.GroupBox40.Name = "GroupBox40"
        Me.GroupBox40.Size = New System.Drawing.Size(464, 60)
        Me.GroupBox40.TabIndex = 50
        Me.GroupBox40.TabStop = False
        Me.GroupBox40.Text = "I.V.A. SOBRE COMPRAS"
        '
        'txtIva2Codigo
        '
        Me.txtIva2Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIva2Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva2Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva2Codigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIva2Codigo.Name = "txtIva2Codigo"
        Me.txtIva2Codigo.ReadOnly = True
        Me.txtIva2Codigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIva2Codigo.TabIndex = 100
        '
        'txtIva2Nombre
        '
        Me.txtIva2Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIva2Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva2Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva2Nombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIva2Nombre.Name = "txtIva2Nombre"
        Me.txtIva2Nombre.ReadOnly = True
        Me.txtIva2Nombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIva2Nombre.TabIndex = 100
        '
        'cmdIva2
        '
        Me.cmdIva2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIva2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIva2.Appearance.Options.UseFont = True
        Me.cmdIva2.Appearance.Options.UseForeColor = True
        Me.cmdIva2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIva2.Image = CType(resources.GetObject("cmdIva2.Image"), System.Drawing.Image)
        Me.cmdIva2.Location = New System.Drawing.Point(416, 17)
        Me.cmdIva2.Name = "cmdIva2"
        Me.cmdIva2.Size = New System.Drawing.Size(32, 35)
        Me.cmdIva2.TabIndex = 1
        '
        'GroupBox41
        '
        Me.GroupBox41.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox41.Controls.Add(Me.txtIva1Codigo)
        Me.GroupBox41.Controls.Add(Me.txtIva1Nombre)
        Me.GroupBox41.Controls.Add(Me.cmdIva1)
        Me.GroupBox41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox41.Location = New System.Drawing.Point(496, 17)
        Me.GroupBox41.Name = "GroupBox41"
        Me.GroupBox41.Size = New System.Drawing.Size(464, 61)
        Me.GroupBox41.TabIndex = 49
        Me.GroupBox41.TabStop = False
        Me.GroupBox41.Text = "I.V.A. POR PAGAR"
        '
        'txtIva1Codigo
        '
        Me.txtIva1Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIva1Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva1Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva1Codigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIva1Codigo.Name = "txtIva1Codigo"
        Me.txtIva1Codigo.ReadOnly = True
        Me.txtIva1Codigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIva1Codigo.TabIndex = 100
        '
        'txtIva1Nombre
        '
        Me.txtIva1Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIva1Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva1Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva1Nombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIva1Nombre.Name = "txtIva1Nombre"
        Me.txtIva1Nombre.ReadOnly = True
        Me.txtIva1Nombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIva1Nombre.TabIndex = 100
        '
        'cmdIva1
        '
        Me.cmdIva1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIva1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIva1.Appearance.Options.UseFont = True
        Me.cmdIva1.Appearance.Options.UseForeColor = True
        Me.cmdIva1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIva1.Image = CType(resources.GetObject("cmdIva1.Image"), System.Drawing.Image)
        Me.cmdIva1.Location = New System.Drawing.Point(416, 17)
        Me.cmdIva1.Name = "cmdIva1"
        Me.cmdIva1.Size = New System.Drawing.Size(32, 35)
        Me.cmdIva1.TabIndex = 1
        '
        'GroupBox31
        '
        Me.GroupBox31.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox31.Controls.Add(Me.txtIRSalarioCodigo)
        Me.GroupBox31.Controls.Add(Me.txtIRSalarioNombre)
        Me.GroupBox31.Controls.Add(Me.cmdIRSalario)
        Me.GroupBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox31.Location = New System.Drawing.Point(496, 224)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(464, 60)
        Me.GroupBox31.TabIndex = 48
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "I.R. SOBRE SALARIO"
        '
        'txtIRSalarioCodigo
        '
        Me.txtIRSalarioCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRSalarioCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRSalarioCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRSalarioCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRSalarioCodigo.Name = "txtIRSalarioCodigo"
        Me.txtIRSalarioCodigo.ReadOnly = True
        Me.txtIRSalarioCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRSalarioCodigo.TabIndex = 100
        '
        'txtIRSalarioNombre
        '
        Me.txtIRSalarioNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRSalarioNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRSalarioNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRSalarioNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIRSalarioNombre.Name = "txtIRSalarioNombre"
        Me.txtIRSalarioNombre.ReadOnly = True
        Me.txtIRSalarioNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRSalarioNombre.TabIndex = 100
        '
        'cmdIRSalario
        '
        Me.cmdIRSalario.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRSalario.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIRSalario.Appearance.Options.UseFont = True
        Me.cmdIRSalario.Appearance.Options.UseForeColor = True
        Me.cmdIRSalario.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIRSalario.Image = CType(resources.GetObject("cmdIRSalario.Image"), System.Drawing.Image)
        Me.cmdIRSalario.Location = New System.Drawing.Point(416, 17)
        Me.cmdIRSalario.Name = "cmdIRSalario"
        Me.cmdIRSalario.Size = New System.Drawing.Size(32, 35)
        Me.cmdIRSalario.TabIndex = 1
        '
        'GroupBox35
        '
        Me.GroupBox35.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox35.Controls.Add(Me.txtIRSRCodigo)
        Me.GroupBox35.Controls.Add(Me.txtIRSRNombre)
        Me.GroupBox35.Controls.Add(Me.cmdIRResidentes)
        Me.GroupBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox35.Location = New System.Drawing.Point(24, 224)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(464, 60)
        Me.GroupBox35.TabIndex = 47
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "I.R. SOBRE RESIDENTES"
        '
        'txtIRSRCodigo
        '
        Me.txtIRSRCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRSRCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRSRCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRSRCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRSRCodigo.Name = "txtIRSRCodigo"
        Me.txtIRSRCodigo.ReadOnly = True
        Me.txtIRSRCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRSRCodigo.TabIndex = 100
        '
        'txtIRSRNombre
        '
        Me.txtIRSRNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRSRNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRSRNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRSRNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIRSRNombre.Name = "txtIRSRNombre"
        Me.txtIRSRNombre.ReadOnly = True
        Me.txtIRSRNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRSRNombre.TabIndex = 100
        '
        'cmdIRResidentes
        '
        Me.cmdIRResidentes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRResidentes.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIRResidentes.Appearance.Options.UseFont = True
        Me.cmdIRResidentes.Appearance.Options.UseForeColor = True
        Me.cmdIRResidentes.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIRResidentes.Image = CType(resources.GetObject("cmdIRResidentes.Image"), System.Drawing.Image)
        Me.cmdIRResidentes.Location = New System.Drawing.Point(416, 17)
        Me.cmdIRResidentes.Name = "cmdIRResidentes"
        Me.cmdIRResidentes.Size = New System.Drawing.Size(32, 35)
        Me.cmdIRResidentes.TabIndex = 1
        '
        'GroupBox37
        '
        Me.GroupBox37.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox37.Controls.Add(Me.txtIRxPCodigo)
        Me.GroupBox37.Controls.Add(Me.txtIRxPNombre)
        Me.GroupBox37.Controls.Add(Me.cmdIRxPagar)
        Me.GroupBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox37.Location = New System.Drawing.Point(24, 86)
        Me.GroupBox37.Name = "GroupBox37"
        Me.GroupBox37.Size = New System.Drawing.Size(464, 60)
        Me.GroupBox37.TabIndex = 46
        Me.GroupBox37.TabStop = False
        Me.GroupBox37.Text = "I.R.  POR PAGAR"
        '
        'txtIRxPCodigo
        '
        Me.txtIRxPCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRxPCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRxPCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRxPCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRxPCodigo.Name = "txtIRxPCodigo"
        Me.txtIRxPCodigo.ReadOnly = True
        Me.txtIRxPCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRxPCodigo.TabIndex = 100
        '
        'txtIRxPNombre
        '
        Me.txtIRxPNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRxPNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRxPNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRxPNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRxPNombre.Name = "txtIRxPNombre"
        Me.txtIRxPNombre.ReadOnly = True
        Me.txtIRxPNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRxPNombre.TabIndex = 100
        '
        'cmdIRxPagar
        '
        Me.cmdIRxPagar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRxPagar.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIRxPagar.Appearance.Options.UseFont = True
        Me.cmdIRxPagar.Appearance.Options.UseForeColor = True
        Me.cmdIRxPagar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIRxPagar.Image = CType(resources.GetObject("cmdIRxPagar.Image"), System.Drawing.Image)
        Me.cmdIRxPagar.Location = New System.Drawing.Point(416, 17)
        Me.cmdIRxPagar.Name = "cmdIRxPagar"
        Me.cmdIRxPagar.Size = New System.Drawing.Size(32, 35)
        Me.cmdIRxPagar.TabIndex = 1
        '
        'GroupBox38
        '
        Me.GroupBox38.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox38.Controls.Add(Me.txtIRAnticipoCodigo)
        Me.GroupBox38.Controls.Add(Me.txtIRAnticipoNombre)
        Me.GroupBox38.Controls.Add(Me.cmdIRAnticipo)
        Me.GroupBox38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox38.Location = New System.Drawing.Point(24, 17)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Size = New System.Drawing.Size(464, 61)
        Me.GroupBox38.TabIndex = 45
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "I.R.  ANTICIPO"
        '
        'txtIRAnticipoCodigo
        '
        Me.txtIRAnticipoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRAnticipoCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRAnticipoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRAnticipoCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRAnticipoCodigo.Name = "txtIRAnticipoCodigo"
        Me.txtIRAnticipoCodigo.ReadOnly = True
        Me.txtIRAnticipoCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRAnticipoCodigo.TabIndex = 100
        '
        'txtIRAnticipoNombre
        '
        Me.txtIRAnticipoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRAnticipoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRAnticipoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRAnticipoNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtIRAnticipoNombre.Name = "txtIRAnticipoNombre"
        Me.txtIRAnticipoNombre.ReadOnly = True
        Me.txtIRAnticipoNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRAnticipoNombre.TabIndex = 100
        '
        'cmdIRAnticipo
        '
        Me.cmdIRAnticipo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRAnticipo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIRAnticipo.Appearance.Options.UseFont = True
        Me.cmdIRAnticipo.Appearance.Options.UseForeColor = True
        Me.cmdIRAnticipo.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIRAnticipo.Image = CType(resources.GetObject("cmdIRAnticipo.Image"), System.Drawing.Image)
        Me.cmdIRAnticipo.Location = New System.Drawing.Point(416, 17)
        Me.cmdIRAnticipo.Name = "cmdIRAnticipo"
        Me.cmdIRAnticipo.Size = New System.Drawing.Size(32, 35)
        Me.cmdIRAnticipo.TabIndex = 1
        '
        'GroupBox39
        '
        Me.GroupBox39.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox39.Controls.Add(Me.txtIRSPCodigo)
        Me.GroupBox39.Controls.Add(Me.txtIRSPNombre)
        Me.GroupBox39.Controls.Add(Me.cmdIRSP)
        Me.GroupBox39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox39.Location = New System.Drawing.Point(24, 155)
        Me.GroupBox39.Name = "GroupBox39"
        Me.GroupBox39.Size = New System.Drawing.Size(464, 60)
        Me.GroupBox39.TabIndex = 44
        Me.GroupBox39.TabStop = False
        Me.GroupBox39.Text = "I.R. SERVICIOS PROFESIONALES"
        '
        'txtIRSPCodigo
        '
        Me.txtIRSPCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRSPCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRSPCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRSPCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtIRSPCodigo.Name = "txtIRSPCodigo"
        Me.txtIRSPCodigo.ReadOnly = True
        Me.txtIRSPCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtIRSPCodigo.TabIndex = 100
        '
        'txtIRSPNombre
        '
        Me.txtIRSPNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRSPNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRSPNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRSPNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIRSPNombre.Name = "txtIRSPNombre"
        Me.txtIRSPNombre.ReadOnly = True
        Me.txtIRSPNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRSPNombre.TabIndex = 100
        '
        'cmdIRSP
        '
        Me.cmdIRSP.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIRSP.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cmdIRSP.Appearance.Options.UseFont = True
        Me.cmdIRSP.Appearance.Options.UseForeColor = True
        Me.cmdIRSP.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdIRSP.Image = CType(resources.GetObject("cmdIRSP.Image"), System.Drawing.Image)
        Me.cmdIRSP.Location = New System.Drawing.Point(416, 17)
        Me.cmdIRSP.Name = "cmdIRSP"
        Me.cmdIRSP.Size = New System.Drawing.Size(32, 35)
        Me.cmdIRSP.TabIndex = 1
        '
        'gbNotaCredito
        '
        Me.gbNotaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbNotaCredito.Controls.Add(Me.GroupBox44)
        Me.gbNotaCredito.Controls.Add(Me.GroupBox47)
        Me.gbNotaCredito.Location = New System.Drawing.Point(8, 107)
        Me.gbNotaCredito.Name = "gbNotaCredito"
        Me.gbNotaCredito.Size = New System.Drawing.Size(1000, 302)
        Me.gbNotaCredito.TabIndex = 53
        Me.gbNotaCredito.TabStop = False
        Me.gbNotaCredito.Visible = False
        '
        'GroupBox44
        '
        Me.GroupBox44.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox44.Controls.Add(Me.txtNCCajaCodigo)
        Me.GroupBox44.Controls.Add(Me.txtNCCajaNombre)
        Me.GroupBox44.Controls.Add(Me.Button26)
        Me.GroupBox44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox44.Location = New System.Drawing.Point(24, 138)
        Me.GroupBox44.Name = "GroupBox44"
        Me.GroupBox44.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox44.TabIndex = 47
        Me.GroupBox44.TabStop = False
        Me.GroupBox44.Text = "CAJA"
        '
        'txtNCCajaCodigo
        '
        Me.txtNCCajaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCCajaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCCajaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCCajaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtNCCajaCodigo.Name = "txtNCCajaCodigo"
        Me.txtNCCajaCodigo.ReadOnly = True
        Me.txtNCCajaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtNCCajaCodigo.TabIndex = 100
        '
        'txtNCCajaNombre
        '
        Me.txtNCCajaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCCajaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCCajaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCCajaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtNCCajaNombre.Name = "txtNCCajaNombre"
        Me.txtNCCajaNombre.ReadOnly = True
        Me.txtNCCajaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNCCajaNombre.TabIndex = 100
        '
        'Button26
        '
        Me.Button26.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button26.Appearance.Options.UseFont = True
        Me.Button26.Appearance.Options.UseForeColor = True
        Me.Button26.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button26.Image = CType(resources.GetObject("Button26.Image"), System.Drawing.Image)
        Me.Button26.Location = New System.Drawing.Point(416, 17)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(32, 35)
        Me.Button26.TabIndex = 1
        '
        'GroupBox47
        '
        Me.GroupBox47.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox47.Controls.Add(Me.txtNCIvaCodigo)
        Me.GroupBox47.Controls.Add(Me.txtNCIvaNombre)
        Me.GroupBox47.Controls.Add(Me.Button30)
        Me.GroupBox47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox47.Location = New System.Drawing.Point(24, 34)
        Me.GroupBox47.Name = "GroupBox47"
        Me.GroupBox47.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox47.TabIndex = 44
        Me.GroupBox47.TabStop = False
        Me.GroupBox47.Text = "IVA POR PAGAR"
        '
        'txtNCIvaCodigo
        '
        Me.txtNCIvaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCIvaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCIvaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCIvaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtNCIvaCodigo.Name = "txtNCIvaCodigo"
        Me.txtNCIvaCodigo.ReadOnly = True
        Me.txtNCIvaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtNCIvaCodigo.TabIndex = 100
        '
        'txtNCIvaNombre
        '
        Me.txtNCIvaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCIvaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCIvaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCIvaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtNCIvaNombre.Name = "txtNCIvaNombre"
        Me.txtNCIvaNombre.ReadOnly = True
        Me.txtNCIvaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNCIvaNombre.TabIndex = 100
        '
        'Button30
        '
        Me.Button30.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button30.Appearance.Options.UseFont = True
        Me.Button30.Appearance.Options.UseForeColor = True
        Me.Button30.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button30.Image = CType(resources.GetObject("Button30.Image"), System.Drawing.Image)
        Me.Button30.Location = New System.Drawing.Point(416, 17)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(32, 35)
        Me.Button30.TabIndex = 1
        '
        'gbNotaDebito
        '
        Me.gbNotaDebito.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbNotaDebito.Controls.Add(Me.GroupBox45)
        Me.gbNotaDebito.Controls.Add(Me.GroupBox46)
        Me.gbNotaDebito.Location = New System.Drawing.Point(8, 124)
        Me.gbNotaDebito.Name = "gbNotaDebito"
        Me.gbNotaDebito.Size = New System.Drawing.Size(1000, 311)
        Me.gbNotaDebito.TabIndex = 54
        Me.gbNotaDebito.TabStop = False
        Me.gbNotaDebito.Visible = False
        '
        'GroupBox45
        '
        Me.GroupBox45.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox45.Controls.Add(Me.txtNDCajaCodigo)
        Me.GroupBox45.Controls.Add(Me.txtNDCajaNombre)
        Me.GroupBox45.Controls.Add(Me.Button28)
        Me.GroupBox45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox45.Location = New System.Drawing.Point(248, 172)
        Me.GroupBox45.Name = "GroupBox45"
        Me.GroupBox45.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox45.TabIndex = 47
        Me.GroupBox45.TabStop = False
        Me.GroupBox45.Text = "CAJA"
        '
        'txtNDCajaCodigo
        '
        Me.txtNDCajaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNDCajaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNDCajaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNDCajaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtNDCajaCodigo.Name = "txtNDCajaCodigo"
        Me.txtNDCajaCodigo.ReadOnly = True
        Me.txtNDCajaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtNDCajaCodigo.TabIndex = 100
        '
        'txtNDCajaNombre
        '
        Me.txtNDCajaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNDCajaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNDCajaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNDCajaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtNDCajaNombre.Name = "txtNDCajaNombre"
        Me.txtNDCajaNombre.ReadOnly = True
        Me.txtNDCajaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNDCajaNombre.TabIndex = 100
        '
        'Button28
        '
        Me.Button28.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button28.Appearance.Options.UseFont = True
        Me.Button28.Appearance.Options.UseForeColor = True
        Me.Button28.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button28.Image = CType(resources.GetObject("Button28.Image"), System.Drawing.Image)
        Me.Button28.Location = New System.Drawing.Point(416, 17)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(32, 35)
        Me.Button28.TabIndex = 1
        '
        'GroupBox46
        '
        Me.GroupBox46.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox46.Controls.Add(Me.txtNDIvaCodigo)
        Me.GroupBox46.Controls.Add(Me.txtNDIvaNombre)
        Me.GroupBox46.Controls.Add(Me.Button29)
        Me.GroupBox46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox46.Location = New System.Drawing.Point(248, 52)
        Me.GroupBox46.Name = "GroupBox46"
        Me.GroupBox46.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox46.TabIndex = 44
        Me.GroupBox46.TabStop = False
        Me.GroupBox46.Text = "IVA POR COBRAR"
        '
        'txtNDIvaCodigo
        '
        Me.txtNDIvaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNDIvaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNDIvaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNDIvaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtNDIvaCodigo.Name = "txtNDIvaCodigo"
        Me.txtNDIvaCodigo.ReadOnly = True
        Me.txtNDIvaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtNDIvaCodigo.TabIndex = 100
        '
        'txtNDIvaNombre
        '
        Me.txtNDIvaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNDIvaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNDIvaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNDIvaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtNDIvaNombre.Name = "txtNDIvaNombre"
        Me.txtNDIvaNombre.ReadOnly = True
        Me.txtNDIvaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNDIvaNombre.TabIndex = 100
        '
        'Button29
        '
        Me.Button29.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button29.Appearance.Options.UseFont = True
        Me.Button29.Appearance.Options.UseForeColor = True
        Me.Button29.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button29.Image = CType(resources.GetObject("Button29.Image"), System.Drawing.Image)
        Me.Button29.Location = New System.Drawing.Point(416, 17)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(32, 35)
        Me.Button29.TabIndex = 1
        '
        'GroupBox52
        '
        Me.GroupBox52.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox52.Controls.Add(Me.GroupBox58)
        Me.GroupBox52.Controls.Add(Me.GroupBox59)
        Me.GroupBox52.Controls.Add(Me.GroupBox60)
        Me.GroupBox52.Controls.Add(Me.GroupBox61)
        Me.GroupBox52.Location = New System.Drawing.Point(8, 124)
        Me.GroupBox52.Name = "GroupBox52"
        Me.GroupBox52.Size = New System.Drawing.Size(1000, 311)
        Me.GroupBox52.TabIndex = 55
        Me.GroupBox52.TabStop = False
        Me.GroupBox52.Visible = False
        '
        'GroupBox58
        '
        Me.GroupBox58.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox58.Controls.Add(Me.TextBox19)
        Me.GroupBox58.Controls.Add(Me.TextBox20)
        Me.GroupBox58.Controls.Add(Me.Button39)
        Me.GroupBox58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox58.Location = New System.Drawing.Point(24, 164)
        Me.GroupBox58.Name = "GroupBox58"
        Me.GroupBox58.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox58.TabIndex = 47
        Me.GroupBox58.TabStop = False
        Me.GroupBox58.Text = "CAJA"
        '
        'TextBox19
        '
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox19.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(8, 26)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(112, 20)
        Me.TextBox19.TabIndex = 100
        '
        'TextBox20
        '
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox20.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(128, 26)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(272, 20)
        Me.TextBox20.TabIndex = 100
        '
        'Button39
        '
        Me.Button39.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button39.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button39.Appearance.Options.UseFont = True
        Me.Button39.Appearance.Options.UseForeColor = True
        Me.Button39.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button39.Image = CType(resources.GetObject("Button39.Image"), System.Drawing.Image)
        Me.Button39.Location = New System.Drawing.Point(416, 17)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(32, 35)
        Me.Button39.TabIndex = 1
        '
        'GroupBox59
        '
        Me.GroupBox59.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox59.Controls.Add(Me.TextBox21)
        Me.GroupBox59.Controls.Add(Me.TextBox22)
        Me.GroupBox59.Controls.Add(Me.Button40)
        Me.GroupBox59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox59.Location = New System.Drawing.Point(504, 164)
        Me.GroupBox59.Name = "GroupBox59"
        Me.GroupBox59.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox59.TabIndex = 46
        Me.GroupBox59.TabStop = False
        Me.GroupBox59.Text = "I.R.  PAGADO POR ANTICIPADO POR SERVICIOS"
        '
        'TextBox21
        '
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(8, 26)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(112, 20)
        Me.TextBox21.TabIndex = 100
        '
        'TextBox22
        '
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(136, 26)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.ReadOnly = True
        Me.TextBox22.Size = New System.Drawing.Size(272, 20)
        Me.TextBox22.TabIndex = 100
        '
        'Button40
        '
        Me.Button40.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button40.Appearance.Options.UseFont = True
        Me.Button40.Appearance.Options.UseForeColor = True
        Me.Button40.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button40.Image = CType(resources.GetObject("Button40.Image"), System.Drawing.Image)
        Me.Button40.Location = New System.Drawing.Point(416, 17)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(32, 35)
        Me.Button40.TabIndex = 1
        '
        'GroupBox60
        '
        Me.GroupBox60.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox60.Controls.Add(Me.TextBox23)
        Me.GroupBox60.Controls.Add(Me.TextBox24)
        Me.GroupBox60.Controls.Add(Me.Button41)
        Me.GroupBox60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox60.Location = New System.Drawing.Point(504, 34)
        Me.GroupBox60.Name = "GroupBox60"
        Me.GroupBox60.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox60.TabIndex = 45
        Me.GroupBox60.TabStop = False
        Me.GroupBox60.Text = "I.R.  PAGADO POR ANTICIPADO POR BIENES"
        '
        'TextBox23
        '
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(8, 26)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.ReadOnly = True
        Me.TextBox23.Size = New System.Drawing.Size(112, 20)
        Me.TextBox23.TabIndex = 100
        '
        'TextBox24
        '
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(136, 26)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.ReadOnly = True
        Me.TextBox24.Size = New System.Drawing.Size(272, 20)
        Me.TextBox24.TabIndex = 100
        '
        'Button41
        '
        Me.Button41.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button41.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button41.Appearance.Options.UseFont = True
        Me.Button41.Appearance.Options.UseForeColor = True
        Me.Button41.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button41.Image = CType(resources.GetObject("Button41.Image"), System.Drawing.Image)
        Me.Button41.Location = New System.Drawing.Point(416, 17)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(32, 35)
        Me.Button41.TabIndex = 1
        '
        'GroupBox61
        '
        Me.GroupBox61.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox61.Controls.Add(Me.TextBox25)
        Me.GroupBox61.Controls.Add(Me.TextBox26)
        Me.GroupBox61.Controls.Add(Me.Button42)
        Me.GroupBox61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox61.Location = New System.Drawing.Point(24, 34)
        Me.GroupBox61.Name = "GroupBox61"
        Me.GroupBox61.Size = New System.Drawing.Size(464, 87)
        Me.GroupBox61.TabIndex = 44
        Me.GroupBox61.TabStop = False
        Me.GroupBox61.Text = "I.R. SOBRE VENTAS"
        '
        'TextBox25
        '
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(8, 26)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.ReadOnly = True
        Me.TextBox25.Size = New System.Drawing.Size(112, 20)
        Me.TextBox25.TabIndex = 100
        '
        'TextBox26
        '
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(128, 26)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(272, 20)
        Me.TextBox26.TabIndex = 100
        '
        'Button42
        '
        Me.Button42.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button42.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button42.Appearance.Options.UseFont = True
        Me.Button42.Appearance.Options.UseForeColor = True
        Me.Button42.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button42.Image = CType(resources.GetObject("Button42.Image"), System.Drawing.Image)
        Me.Button42.Location = New System.Drawing.Point(416, 17)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(32, 35)
        Me.Button42.TabIndex = 1
        '
        'gbAlcaldia
        '
        Me.gbAlcaldia.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbAlcaldia.Controls.Add(Me.GroupBox54)
        Me.gbAlcaldia.Controls.Add(Me.GroupBox57)
        Me.gbAlcaldia.Location = New System.Drawing.Point(16, 133)
        Me.gbAlcaldia.Name = "gbAlcaldia"
        Me.gbAlcaldia.Size = New System.Drawing.Size(1000, 336)
        Me.gbAlcaldia.TabIndex = 48
        Me.gbAlcaldia.TabStop = False
        Me.gbAlcaldia.Visible = False
        '
        'GroupBox54
        '
        Me.GroupBox54.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox54.Controls.Add(Me.txtAlcaldiaCajaCodigo)
        Me.GroupBox54.Controls.Add(Me.txtAlcaldiaCajaNombre)
        Me.GroupBox54.Controls.Add(Me.Button35)
        Me.GroupBox54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox54.Location = New System.Drawing.Point(280, 129)
        Me.GroupBox54.Name = "GroupBox54"
        Me.GroupBox54.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox54.TabIndex = 47
        Me.GroupBox54.TabStop = False
        Me.GroupBox54.Text = "CAJA"
        '
        'txtAlcaldiaCajaCodigo
        '
        Me.txtAlcaldiaCajaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlcaldiaCajaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlcaldiaCajaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcaldiaCajaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtAlcaldiaCajaCodigo.Name = "txtAlcaldiaCajaCodigo"
        Me.txtAlcaldiaCajaCodigo.ReadOnly = True
        Me.txtAlcaldiaCajaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtAlcaldiaCajaCodigo.TabIndex = 100
        '
        'txtAlcaldiaCajaNombre
        '
        Me.txtAlcaldiaCajaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlcaldiaCajaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlcaldiaCajaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcaldiaCajaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtAlcaldiaCajaNombre.Name = "txtAlcaldiaCajaNombre"
        Me.txtAlcaldiaCajaNombre.ReadOnly = True
        Me.txtAlcaldiaCajaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtAlcaldiaCajaNombre.TabIndex = 100
        '
        'Button35
        '
        Me.Button35.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button35.Appearance.Options.UseFont = True
        Me.Button35.Appearance.Options.UseForeColor = True
        Me.Button35.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button35.Location = New System.Drawing.Point(416, 17)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(32, 35)
        Me.Button35.TabIndex = 1
        '
        'GroupBox57
        '
        Me.GroupBox57.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox57.Controls.Add(Me.txtAlcaldiaCodigo)
        Me.GroupBox57.Controls.Add(Me.txtAlcaldiaNombre)
        Me.GroupBox57.Controls.Add(Me.Button38)
        Me.GroupBox57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox57.Location = New System.Drawing.Point(280, 26)
        Me.GroupBox57.Name = "GroupBox57"
        Me.GroupBox57.Size = New System.Drawing.Size(464, 86)
        Me.GroupBox57.TabIndex = 44
        Me.GroupBox57.TabStop = False
        Me.GroupBox57.Text = "ALCALDIA"
        '
        'txtAlcaldiaCodigo
        '
        Me.txtAlcaldiaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlcaldiaCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlcaldiaCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcaldiaCodigo.Location = New System.Drawing.Point(8, 26)
        Me.txtAlcaldiaCodigo.Name = "txtAlcaldiaCodigo"
        Me.txtAlcaldiaCodigo.ReadOnly = True
        Me.txtAlcaldiaCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtAlcaldiaCodigo.TabIndex = 100
        '
        'txtAlcaldiaNombre
        '
        Me.txtAlcaldiaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlcaldiaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlcaldiaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcaldiaNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtAlcaldiaNombre.Name = "txtAlcaldiaNombre"
        Me.txtAlcaldiaNombre.ReadOnly = True
        Me.txtAlcaldiaNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtAlcaldiaNombre.TabIndex = 100
        '
        'Button38
        '
        Me.Button38.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button38.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button38.Appearance.Options.UseFont = True
        Me.Button38.Appearance.Options.UseForeColor = True
        Me.Button38.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button38.Location = New System.Drawing.Point(416, 17)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(32, 35)
        Me.Button38.TabIndex = 1
        '
        'gbMttoValor
        '
        Me.gbMttoValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbMttoValor.Controls.Add(Me.GroupBox64)
        Me.gbMttoValor.Controls.Add(Me.gbexgreso)
        Me.gbMttoValor.Location = New System.Drawing.Point(8, 116)
        Me.gbMttoValor.Name = "gbMttoValor"
        Me.gbMttoValor.Size = New System.Drawing.Size(1000, 319)
        Me.gbMttoValor.TabIndex = 56
        Me.gbMttoValor.TabStop = False
        Me.gbMttoValor.Visible = False
        '
        'GroupBox64
        '
        Me.GroupBox64.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox64.Controls.Add(Me.txtIngresoMtto)
        Me.GroupBox64.Controls.Add(Me.txtIngresoMttoNombre)
        Me.GroupBox64.Controls.Add(Me.Button45)
        Me.GroupBox64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox64.Location = New System.Drawing.Point(24, 26)
        Me.GroupBox64.Name = "GroupBox64"
        Me.GroupBox64.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox64.TabIndex = 43
        Me.GroupBox64.TabStop = False
        Me.GroupBox64.Text = "Ingreso Por Mantenimiento de Valor"
        '
        'txtIngresoMtto
        '
        Me.txtIngresoMtto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngresoMtto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIngresoMtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresoMtto.Location = New System.Drawing.Point(8, 26)
        Me.txtIngresoMtto.Name = "txtIngresoMtto"
        Me.txtIngresoMtto.ReadOnly = True
        Me.txtIngresoMtto.Size = New System.Drawing.Size(112, 20)
        Me.txtIngresoMtto.TabIndex = 100
        '
        'txtIngresoMttoNombre
        '
        Me.txtIngresoMttoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngresoMttoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIngresoMttoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresoMttoNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtIngresoMttoNombre.Name = "txtIngresoMttoNombre"
        Me.txtIngresoMttoNombre.ReadOnly = True
        Me.txtIngresoMttoNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIngresoMttoNombre.TabIndex = 100
        '
        'Button45
        '
        Me.Button45.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button45.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button45.Appearance.Options.UseFont = True
        Me.Button45.Appearance.Options.UseForeColor = True
        Me.Button45.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button45.Image = CType(resources.GetObject("Button45.Image"), System.Drawing.Image)
        Me.Button45.Location = New System.Drawing.Point(416, 17)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(32, 35)
        Me.Button45.TabIndex = 1
        '
        'gbexgreso
        '
        Me.gbexgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbexgreso.Controls.Add(Me.txtEgresoMtto)
        Me.gbexgreso.Controls.Add(Me.txtEgresoMttoNombre)
        Me.gbexgreso.Controls.Add(Me.Button46)
        Me.gbexgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbexgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbexgreso.Location = New System.Drawing.Point(24, 164)
        Me.gbexgreso.Name = "gbexgreso"
        Me.gbexgreso.Size = New System.Drawing.Size(464, 112)
        Me.gbexgreso.TabIndex = 103
        Me.gbexgreso.TabStop = False
        Me.gbexgreso.Text = "Egreso Por Mantenimiento de Valor"
        '
        'txtEgresoMtto
        '
        Me.txtEgresoMtto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEgresoMtto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEgresoMtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresoMtto.Location = New System.Drawing.Point(8, 26)
        Me.txtEgresoMtto.Name = "txtEgresoMtto"
        Me.txtEgresoMtto.ReadOnly = True
        Me.txtEgresoMtto.Size = New System.Drawing.Size(112, 20)
        Me.txtEgresoMtto.TabIndex = 100
        '
        'txtEgresoMttoNombre
        '
        Me.txtEgresoMttoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEgresoMttoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEgresoMttoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresoMttoNombre.Location = New System.Drawing.Point(128, 26)
        Me.txtEgresoMttoNombre.Name = "txtEgresoMttoNombre"
        Me.txtEgresoMttoNombre.ReadOnly = True
        Me.txtEgresoMttoNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtEgresoMttoNombre.TabIndex = 100
        '
        'Button46
        '
        Me.Button46.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button46.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button46.Appearance.Options.UseFont = True
        Me.Button46.Appearance.Options.UseForeColor = True
        Me.Button46.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button46.Image = CType(resources.GetObject("Button46.Image"), System.Drawing.Image)
        Me.Button46.Location = New System.Drawing.Point(416, 17)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(32, 35)
        Me.Button46.TabIndex = 1
        '
        'gbPagoProductos
        '
        Me.gbPagoProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbPagoProductos.Controls.Add(Me.GroupBox65)
        Me.gbPagoProductos.Controls.Add(Me.GroupBox66)
        Me.gbPagoProductos.Controls.Add(Me.GroupBox67)
        Me.gbPagoProductos.Location = New System.Drawing.Point(8, 133)
        Me.gbPagoProductos.Name = "gbPagoProductos"
        Me.gbPagoProductos.Size = New System.Drawing.Size(1000, 293)
        Me.gbPagoProductos.TabIndex = 57
        Me.gbPagoProductos.TabStop = False
        Me.gbPagoProductos.Visible = False
        '
        'GroupBox65
        '
        Me.GroupBox65.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox65.Controls.Add(Me.txtProdBancos)
        Me.GroupBox65.Controls.Add(Me.txtProdBancosNombre)
        Me.GroupBox65.Controls.Add(Me.Button49)
        Me.GroupBox65.Controls.Add(Me.cBancosProdVar)
        Me.GroupBox65.Controls.Add(Me.cBancosProdC)
        Me.GroupBox65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox65.Location = New System.Drawing.Point(272, 155)
        Me.GroupBox65.Name = "GroupBox65"
        Me.GroupBox65.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox65.TabIndex = 45
        Me.GroupBox65.TabStop = False
        Me.GroupBox65.Text = "BANCOS"
        '
        'txtProdBancos
        '
        Me.txtProdBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdBancos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdBancos.Location = New System.Drawing.Point(12, 26)
        Me.txtProdBancos.Name = "txtProdBancos"
        Me.txtProdBancos.ReadOnly = True
        Me.txtProdBancos.Size = New System.Drawing.Size(112, 20)
        Me.txtProdBancos.TabIndex = 103
        '
        'txtProdBancosNombre
        '
        Me.txtProdBancosNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdBancosNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdBancosNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdBancosNombre.Location = New System.Drawing.Point(132, 26)
        Me.txtProdBancosNombre.Name = "txtProdBancosNombre"
        Me.txtProdBancosNombre.ReadOnly = True
        Me.txtProdBancosNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtProdBancosNombre.TabIndex = 102
        '
        'Button49
        '
        Me.Button49.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button49.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button49.Appearance.Options.UseFont = True
        Me.Button49.Appearance.Options.UseForeColor = True
        Me.Button49.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button49.Image = CType(resources.GetObject("Button49.Image"), System.Drawing.Image)
        Me.Button49.Location = New System.Drawing.Point(420, 17)
        Me.Button49.Name = "Button49"
        Me.Button49.Size = New System.Drawing.Size(32, 35)
        Me.Button49.TabIndex = 101
        '
        'cBancosProdVar
        '
        Me.cBancosProdVar.ItemHeight = 13
        Me.cBancosProdVar.Location = New System.Drawing.Point(264, 60)
        Me.cBancosProdVar.Name = "cBancosProdVar"
        Me.cBancosProdVar.Size = New System.Drawing.Size(184, 21)
        Me.cBancosProdVar.TabIndex = 3
        '
        'cBancosProdC
        '
        Me.cBancosProdC.ItemHeight = 13
        Me.cBancosProdC.Location = New System.Drawing.Point(8, 60)
        Me.cBancosProdC.Name = "cBancosProdC"
        Me.cBancosProdC.Size = New System.Drawing.Size(248, 21)
        Me.cBancosProdC.TabIndex = 2
        '
        'GroupBox66
        '
        Me.GroupBox66.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox66.Controls.Add(Me.cbProvProdVar)
        Me.GroupBox66.Controls.Add(Me.cbProvProdC)
        Me.GroupBox66.Controls.Add(Me.Button48)
        Me.GroupBox66.Controls.Add(Me.txtProdProvCta)
        Me.GroupBox66.Controls.Add(Me.txtProdProvNombre)
        Me.GroupBox66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox66.Location = New System.Drawing.Point(512, 26)
        Me.GroupBox66.Name = "GroupBox66"
        Me.GroupBox66.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox66.TabIndex = 44
        Me.GroupBox66.TabStop = False
        Me.GroupBox66.Text = "PROVEEDOR"
        '
        'cbProvProdVar
        '
        Me.cbProvProdVar.ItemHeight = 13
        Me.cbProvProdVar.Location = New System.Drawing.Point(264, 60)
        Me.cbProvProdVar.Name = "cbProvProdVar"
        Me.cbProvProdVar.Size = New System.Drawing.Size(184, 21)
        Me.cbProvProdVar.TabIndex = 3
        '
        'cbProvProdC
        '
        Me.cbProvProdC.ItemHeight = 13
        Me.cbProvProdC.Location = New System.Drawing.Point(8, 60)
        Me.cbProvProdC.Name = "cbProvProdC"
        Me.cbProvProdC.Size = New System.Drawing.Size(248, 21)
        Me.cbProvProdC.TabIndex = 2
        '
        'Button48
        '
        Me.Button48.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button48.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button48.Appearance.Options.UseFont = True
        Me.Button48.Appearance.Options.UseForeColor = True
        Me.Button48.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button48.Image = CType(resources.GetObject("Button48.Image"), System.Drawing.Image)
        Me.Button48.Location = New System.Drawing.Point(424, 17)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(32, 35)
        Me.Button48.TabIndex = 101
        '
        'txtProdProvCta
        '
        Me.txtProdProvCta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdProvCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdProvCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdProvCta.Location = New System.Drawing.Point(16, 26)
        Me.txtProdProvCta.Name = "txtProdProvCta"
        Me.txtProdProvCta.ReadOnly = True
        Me.txtProdProvCta.Size = New System.Drawing.Size(112, 20)
        Me.txtProdProvCta.TabIndex = 103
        '
        'txtProdProvNombre
        '
        Me.txtProdProvNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdProvNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdProvNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdProvNombre.Location = New System.Drawing.Point(136, 26)
        Me.txtProdProvNombre.Name = "txtProdProvNombre"
        Me.txtProdProvNombre.ReadOnly = True
        Me.txtProdProvNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtProdProvNombre.TabIndex = 102
        '
        'GroupBox67
        '
        Me.GroupBox67.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox67.Controls.Add(Me.txtProdIVACta)
        Me.GroupBox67.Controls.Add(Me.txtProdIVANombre)
        Me.GroupBox67.Controls.Add(Me.cbIVAProdVar)
        Me.GroupBox67.Controls.Add(Me.cbIVAProdC)
        Me.GroupBox67.Controls.Add(Me.Button47)
        Me.GroupBox67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox67.Location = New System.Drawing.Point(24, 26)
        Me.GroupBox67.Name = "GroupBox67"
        Me.GroupBox67.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox67.TabIndex = 43
        Me.GroupBox67.TabStop = False
        Me.GroupBox67.Text = "I.R."
        '
        'txtProdIVACta
        '
        Me.txtProdIVACta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdIVACta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdIVACta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdIVACta.Location = New System.Drawing.Point(8, 26)
        Me.txtProdIVACta.Name = "txtProdIVACta"
        Me.txtProdIVACta.ReadOnly = True
        Me.txtProdIVACta.Size = New System.Drawing.Size(112, 20)
        Me.txtProdIVACta.TabIndex = 100
        '
        'txtProdIVANombre
        '
        Me.txtProdIVANombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdIVANombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdIVANombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdIVANombre.Location = New System.Drawing.Point(128, 26)
        Me.txtProdIVANombre.Name = "txtProdIVANombre"
        Me.txtProdIVANombre.ReadOnly = True
        Me.txtProdIVANombre.Size = New System.Drawing.Size(272, 20)
        Me.txtProdIVANombre.TabIndex = 100
        '
        'cbIVAProdVar
        '
        Me.cbIVAProdVar.ItemHeight = 13
        Me.cbIVAProdVar.Location = New System.Drawing.Point(264, 60)
        Me.cbIVAProdVar.Name = "cbIVAProdVar"
        Me.cbIVAProdVar.Size = New System.Drawing.Size(184, 21)
        Me.cbIVAProdVar.TabIndex = 3
        '
        'cbIVAProdC
        '
        Me.cbIVAProdC.ItemHeight = 13
        Me.cbIVAProdC.Location = New System.Drawing.Point(8, 60)
        Me.cbIVAProdC.Name = "cbIVAProdC"
        Me.cbIVAProdC.Size = New System.Drawing.Size(248, 21)
        Me.cbIVAProdC.TabIndex = 2
        '
        'Button47
        '
        Me.Button47.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button47.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button47.Appearance.Options.UseFont = True
        Me.Button47.Appearance.Options.UseForeColor = True
        Me.Button47.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button47.Image = CType(resources.GetObject("Button47.Image"), System.Drawing.Image)
        Me.Button47.Location = New System.Drawing.Point(416, 17)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(32, 35)
        Me.Button47.TabIndex = 1
        '
        'gbProveedoresServicios
        '
        Me.gbProveedoresServicios.Controls.Add(Me.GroupBox77)
        Me.gbProveedoresServicios.Controls.Add(Me.GroupBox70)
        Me.gbProveedoresServicios.Controls.Add(Me.GroupBox63)
        Me.gbProveedoresServicios.Controls.Add(Me.GroupBox68)
        Me.gbProveedoresServicios.Controls.Add(Me.GroupBox69)
        Me.gbProveedoresServicios.Controls.Add(Me.GroupBox71)
        Me.gbProveedoresServicios.Location = New System.Drawing.Point(8, 116)
        Me.gbProveedoresServicios.Name = "gbProveedoresServicios"
        Me.gbProveedoresServicios.Size = New System.Drawing.Size(1008, 439)
        Me.gbProveedoresServicios.TabIndex = 47
        Me.gbProveedoresServicios.TabStop = False
        '
        'GroupBox77
        '
        Me.GroupBox77.Controls.Add(Me.cbIRxPagAlcC)
        Me.GroupBox77.Controls.Add(Me.cbIRxPagAlcVar)
        Me.GroupBox77.Controls.Add(Me.Button61)
        Me.GroupBox77.Controls.Add(Me.txtIRPagoAlcNombre)
        Me.GroupBox77.Controls.Add(Me.txtIRPagoAlcCuenta)
        Me.GroupBox77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox77.Location = New System.Drawing.Point(496, 284)
        Me.GroupBox77.Name = "GroupBox77"
        Me.GroupBox77.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox77.TabIndex = 49
        Me.GroupBox77.TabStop = False
        Me.GroupBox77.Text = "I.R. I.R. PAGO ALCALDIA"
        '
        'cbIRxPagAlcC
        '
        Me.cbIRxPagAlcC.Location = New System.Drawing.Point(12, 75)
        Me.cbIRxPagAlcC.Name = "cbIRxPagAlcC"
        Me.cbIRxPagAlcC.Size = New System.Drawing.Size(248, 21)
        Me.cbIRxPagAlcC.TabIndex = 10
        '
        'cbIRxPagAlcVar
        '
        Me.cbIRxPagAlcVar.Location = New System.Drawing.Point(268, 75)
        Me.cbIRxPagAlcVar.Name = "cbIRxPagAlcVar"
        Me.cbIRxPagAlcVar.Size = New System.Drawing.Size(184, 21)
        Me.cbIRxPagAlcVar.TabIndex = 11
        '
        'Button61
        '
        Me.Button61.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button61.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button61.Appearance.Options.UseFont = True
        Me.Button61.Appearance.Options.UseForeColor = True
        Me.Button61.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button61.Image = CType(resources.GetObject("Button61.Image"), System.Drawing.Image)
        Me.Button61.Location = New System.Drawing.Point(420, 32)
        Me.Button61.Name = "Button61"
        Me.Button61.Size = New System.Drawing.Size(32, 35)
        Me.Button61.TabIndex = 9
        '
        'txtIRPagoAlcNombre
        '
        Me.txtIRPagoAlcNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagoAlcNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPagoAlcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPagoAlcNombre.Location = New System.Drawing.Point(140, 41)
        Me.txtIRPagoAlcNombre.Name = "txtIRPagoAlcNombre"
        Me.txtIRPagoAlcNombre.ReadOnly = True
        Me.txtIRPagoAlcNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRPagoAlcNombre.TabIndex = 100
        '
        'txtIRPagoAlcCuenta
        '
        Me.txtIRPagoAlcCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagoAlcCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPagoAlcCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPagoAlcCuenta.Location = New System.Drawing.Point(16, 41)
        Me.txtIRPagoAlcCuenta.Name = "txtIRPagoAlcCuenta"
        Me.txtIRPagoAlcCuenta.ReadOnly = True
        Me.txtIRPagoAlcCuenta.Size = New System.Drawing.Size(112, 20)
        Me.txtIRPagoAlcCuenta.TabIndex = 100
        '
        'GroupBox70
        '
        Me.GroupBox70.Controls.Add(Me.cbIRxPagarC)
        Me.GroupBox70.Controls.Add(Me.cbIRxPagarV)
        Me.GroupBox70.Controls.Add(Me.Button56)
        Me.GroupBox70.Controls.Add(Me.txtIRxPagarN)
        Me.GroupBox70.Controls.Add(Me.txtIRxPagarC)
        Me.GroupBox70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox70.Location = New System.Drawing.Point(8, 284)
        Me.GroupBox70.Name = "GroupBox70"
        Me.GroupBox70.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox70.TabIndex = 48
        Me.GroupBox70.TabStop = False
        Me.GroupBox70.Text = "I.R. POR PAGAR SERVICIOS"
        '
        'cbIRxPagarC
        '
        Me.cbIRxPagarC.Location = New System.Drawing.Point(12, 75)
        Me.cbIRxPagarC.Name = "cbIRxPagarC"
        Me.cbIRxPagarC.Size = New System.Drawing.Size(248, 21)
        Me.cbIRxPagarC.TabIndex = 10
        '
        'cbIRxPagarV
        '
        Me.cbIRxPagarV.Location = New System.Drawing.Point(268, 75)
        Me.cbIRxPagarV.Name = "cbIRxPagarV"
        Me.cbIRxPagarV.Size = New System.Drawing.Size(184, 21)
        Me.cbIRxPagarV.TabIndex = 11
        '
        'Button56
        '
        Me.Button56.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button56.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button56.Appearance.Options.UseFont = True
        Me.Button56.Appearance.Options.UseForeColor = True
        Me.Button56.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button56.Image = CType(resources.GetObject("Button56.Image"), System.Drawing.Image)
        Me.Button56.Location = New System.Drawing.Point(420, 32)
        Me.Button56.Name = "Button56"
        Me.Button56.Size = New System.Drawing.Size(32, 35)
        Me.Button56.TabIndex = 9
        '
        'txtIRxPagarN
        '
        Me.txtIRxPagarN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRxPagarN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRxPagarN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRxPagarN.Location = New System.Drawing.Point(140, 41)
        Me.txtIRxPagarN.Name = "txtIRxPagarN"
        Me.txtIRxPagarN.ReadOnly = True
        Me.txtIRxPagarN.Size = New System.Drawing.Size(272, 20)
        Me.txtIRxPagarN.TabIndex = 100
        '
        'txtIRxPagarC
        '
        Me.txtIRxPagarC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRxPagarC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRxPagarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRxPagarC.Location = New System.Drawing.Point(16, 41)
        Me.txtIRxPagarC.Name = "txtIRxPagarC"
        Me.txtIRxPagarC.ReadOnly = True
        Me.txtIRxPagarC.Size = New System.Drawing.Size(112, 20)
        Me.txtIRxPagarC.TabIndex = 100
        '
        'GroupBox63
        '
        Me.GroupBox63.Controls.Add(Me.CBIVAPORCOBRAR)
        Me.GroupBox63.Controls.Add(Me.CBIVAPORCOBRARVAR)
        Me.GroupBox63.Controls.Add(Me.Button53)
        Me.GroupBox63.Controls.Add(Me.TXTIVAPORCOBRARNOMBRE)
        Me.GroupBox63.Controls.Add(Me.TXTIVAXCOBRAR)
        Me.GroupBox63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox63.Location = New System.Drawing.Point(488, 17)
        Me.GroupBox63.Name = "GroupBox63"
        Me.GroupBox63.Size = New System.Drawing.Size(464, 121)
        Me.GroupBox63.TabIndex = 47
        Me.GroupBox63.TabStop = False
        Me.GroupBox63.Text = "I.V.A. POR  COBRAR"
        '
        'CBIVAPORCOBRAR
        '
        Me.CBIVAPORCOBRAR.Location = New System.Drawing.Point(12, 75)
        Me.CBIVAPORCOBRAR.Name = "CBIVAPORCOBRAR"
        Me.CBIVAPORCOBRAR.Size = New System.Drawing.Size(248, 21)
        Me.CBIVAPORCOBRAR.TabIndex = 7
        '
        'CBIVAPORCOBRARVAR
        '
        Me.CBIVAPORCOBRARVAR.Location = New System.Drawing.Point(268, 75)
        Me.CBIVAPORCOBRARVAR.Name = "CBIVAPORCOBRARVAR"
        Me.CBIVAPORCOBRARVAR.Size = New System.Drawing.Size(184, 21)
        Me.CBIVAPORCOBRARVAR.TabIndex = 8
        '
        'Button53
        '
        Me.Button53.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button53.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button53.Appearance.Options.UseFont = True
        Me.Button53.Appearance.Options.UseForeColor = True
        Me.Button53.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button53.Image = CType(resources.GetObject("Button53.Image"), System.Drawing.Image)
        Me.Button53.Location = New System.Drawing.Point(420, 26)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(32, 34)
        Me.Button53.TabIndex = 7
        '
        'TXTIVAPORCOBRARNOMBRE
        '
        Me.TXTIVAPORCOBRARNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTIVAPORCOBRARNOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIVAPORCOBRARNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIVAPORCOBRARNOMBRE.Location = New System.Drawing.Point(132, 34)
        Me.TXTIVAPORCOBRARNOMBRE.Name = "TXTIVAPORCOBRARNOMBRE"
        Me.TXTIVAPORCOBRARNOMBRE.ReadOnly = True
        Me.TXTIVAPORCOBRARNOMBRE.Size = New System.Drawing.Size(280, 20)
        Me.TXTIVAPORCOBRARNOMBRE.TabIndex = 100
        '
        'TXTIVAXCOBRAR
        '
        Me.TXTIVAXCOBRAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTIVAXCOBRAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIVAXCOBRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIVAXCOBRAR.Location = New System.Drawing.Point(12, 34)
        Me.TXTIVAXCOBRAR.Name = "TXTIVAXCOBRAR"
        Me.TXTIVAXCOBRAR.ReadOnly = True
        Me.TXTIVAXCOBRAR.Size = New System.Drawing.Size(112, 20)
        Me.TXTIVAXCOBRAR.TabIndex = 100
        '
        'GroupBox68
        '
        Me.GroupBox68.Controls.Add(Me.CBIRXPAGAR)
        Me.GroupBox68.Controls.Add(Me.CBIRXPAGARVAR)
        Me.GroupBox68.Controls.Add(Me.Button50)
        Me.GroupBox68.Controls.Add(Me.TXTIRXPAGARNOMBRE)
        Me.GroupBox68.Controls.Add(Me.TXTIRXPAGARCUENTA)
        Me.GroupBox68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox68.Location = New System.Drawing.Point(488, 155)
        Me.GroupBox68.Name = "GroupBox68"
        Me.GroupBox68.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox68.TabIndex = 46
        Me.GroupBox68.TabStop = False
        Me.GroupBox68.Text = "I.R. POR PAGAR  PROD/SERV"
        '
        'CBIRXPAGAR
        '
        Me.CBIRXPAGAR.Location = New System.Drawing.Point(12, 75)
        Me.CBIRXPAGAR.Name = "CBIRXPAGAR"
        Me.CBIRXPAGAR.Size = New System.Drawing.Size(248, 21)
        Me.CBIRXPAGAR.TabIndex = 10
        '
        'CBIRXPAGARVAR
        '
        Me.CBIRXPAGARVAR.Location = New System.Drawing.Point(268, 75)
        Me.CBIRXPAGARVAR.Name = "CBIRXPAGARVAR"
        Me.CBIRXPAGARVAR.Size = New System.Drawing.Size(184, 21)
        Me.CBIRXPAGARVAR.TabIndex = 11
        '
        'Button50
        '
        Me.Button50.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button50.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button50.Appearance.Options.UseFont = True
        Me.Button50.Appearance.Options.UseForeColor = True
        Me.Button50.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button50.Image = CType(resources.GetObject("Button50.Image"), System.Drawing.Image)
        Me.Button50.Location = New System.Drawing.Point(420, 32)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(32, 35)
        Me.Button50.TabIndex = 9
        '
        'TXTIRXPAGARNOMBRE
        '
        Me.TXTIRXPAGARNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTIRXPAGARNOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIRXPAGARNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIRXPAGARNOMBRE.Location = New System.Drawing.Point(140, 41)
        Me.TXTIRXPAGARNOMBRE.Name = "TXTIRXPAGARNOMBRE"
        Me.TXTIRXPAGARNOMBRE.ReadOnly = True
        Me.TXTIRXPAGARNOMBRE.Size = New System.Drawing.Size(272, 20)
        Me.TXTIRXPAGARNOMBRE.TabIndex = 100
        '
        'TXTIRXPAGARCUENTA
        '
        Me.TXTIRXPAGARCUENTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTIRXPAGARCUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIRXPAGARCUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIRXPAGARCUENTA.Location = New System.Drawing.Point(16, 41)
        Me.TXTIRXPAGARCUENTA.Name = "TXTIRXPAGARCUENTA"
        Me.TXTIRXPAGARCUENTA.ReadOnly = True
        Me.TXTIRXPAGARCUENTA.Size = New System.Drawing.Size(112, 20)
        Me.TXTIRXPAGARCUENTA.TabIndex = 100
        '
        'GroupBox69
        '
        Me.GroupBox69.Controls.Add(Me.CBPROVEEDOR)
        Me.GroupBox69.Controls.Add(Me.CBPROVEEDORVAR)
        Me.GroupBox69.Controls.Add(Me.Button51)
        Me.GroupBox69.Controls.Add(Me.TXTPROVEEDORNOMBRE)
        Me.GroupBox69.Controls.Add(Me.TXTPROVEEDORCUENTA)
        Me.GroupBox69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox69.Location = New System.Drawing.Point(8, 155)
        Me.GroupBox69.Name = "GroupBox69"
        Me.GroupBox69.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox69.TabIndex = 44
        Me.GroupBox69.TabStop = False
        Me.GroupBox69.Text = "PROVEEDOR"
        '
        'CBPROVEEDOR
        '
        Me.CBPROVEEDOR.Location = New System.Drawing.Point(12, 75)
        Me.CBPROVEEDOR.Name = "CBPROVEEDOR"
        Me.CBPROVEEDOR.Size = New System.Drawing.Size(248, 21)
        Me.CBPROVEEDOR.TabIndex = 7
        '
        'CBPROVEEDORVAR
        '
        Me.CBPROVEEDORVAR.Location = New System.Drawing.Point(268, 75)
        Me.CBPROVEEDORVAR.Name = "CBPROVEEDORVAR"
        Me.CBPROVEEDORVAR.Size = New System.Drawing.Size(184, 21)
        Me.CBPROVEEDORVAR.TabIndex = 8
        '
        'Button51
        '
        Me.Button51.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button51.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button51.Appearance.Options.UseFont = True
        Me.Button51.Appearance.Options.UseForeColor = True
        Me.Button51.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button51.Image = CType(resources.GetObject("Button51.Image"), System.Drawing.Image)
        Me.Button51.Location = New System.Drawing.Point(420, 32)
        Me.Button51.Name = "Button51"
        Me.Button51.Size = New System.Drawing.Size(32, 35)
        Me.Button51.TabIndex = 7
        '
        'TXTPROVEEDORNOMBRE
        '
        Me.TXTPROVEEDORNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPROVEEDORNOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPROVEEDORNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPROVEEDORNOMBRE.Location = New System.Drawing.Point(132, 41)
        Me.TXTPROVEEDORNOMBRE.Name = "TXTPROVEEDORNOMBRE"
        Me.TXTPROVEEDORNOMBRE.ReadOnly = True
        Me.TXTPROVEEDORNOMBRE.Size = New System.Drawing.Size(280, 20)
        Me.TXTPROVEEDORNOMBRE.TabIndex = 100
        '
        'TXTPROVEEDORCUENTA
        '
        Me.TXTPROVEEDORCUENTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPROVEEDORCUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPROVEEDORCUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPROVEEDORCUENTA.Location = New System.Drawing.Point(12, 41)
        Me.TXTPROVEEDORCUENTA.Name = "TXTPROVEEDORCUENTA"
        Me.TXTPROVEEDORCUENTA.ReadOnly = True
        Me.TXTPROVEEDORCUENTA.Size = New System.Drawing.Size(112, 20)
        Me.TXTPROVEEDORCUENTA.TabIndex = 100
        '
        'GroupBox71
        '
        Me.GroupBox71.Controls.Add(Me.Button52)
        Me.GroupBox71.Controls.Add(Me.TXTGASTOSNOMBRE)
        Me.GroupBox71.Controls.Add(Me.TXTGASTOSCUENTA)
        Me.GroupBox71.Controls.Add(Me.CBGASTOSVAR)
        Me.GroupBox71.Controls.Add(Me.CBGASTOS)
        Me.GroupBox71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox71.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox71.Name = "GroupBox71"
        Me.GroupBox71.Size = New System.Drawing.Size(464, 121)
        Me.GroupBox71.TabIndex = 43
        Me.GroupBox71.TabStop = False
        Me.GroupBox71.Text = "GASTOS"
        '
        'Button52
        '
        Me.Button52.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button52.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button52.Appearance.Options.UseFont = True
        Me.Button52.Appearance.Options.UseForeColor = True
        Me.Button52.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button52.Image = CType(resources.GetObject("Button52.Image"), System.Drawing.Image)
        Me.Button52.Location = New System.Drawing.Point(420, 26)
        Me.Button52.Name = "Button52"
        Me.Button52.Size = New System.Drawing.Size(32, 34)
        Me.Button52.TabIndex = 101
        '
        'TXTGASTOSNOMBRE
        '
        Me.TXTGASTOSNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTGASTOSNOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTGASTOSNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGASTOSNOMBRE.Location = New System.Drawing.Point(132, 34)
        Me.TXTGASTOSNOMBRE.Name = "TXTGASTOSNOMBRE"
        Me.TXTGASTOSNOMBRE.ReadOnly = True
        Me.TXTGASTOSNOMBRE.Size = New System.Drawing.Size(280, 20)
        Me.TXTGASTOSNOMBRE.TabIndex = 103
        '
        'TXTGASTOSCUENTA
        '
        Me.TXTGASTOSCUENTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTGASTOSCUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTGASTOSCUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGASTOSCUENTA.Location = New System.Drawing.Point(12, 34)
        Me.TXTGASTOSCUENTA.Name = "TXTGASTOSCUENTA"
        Me.TXTGASTOSCUENTA.ReadOnly = True
        Me.TXTGASTOSCUENTA.Size = New System.Drawing.Size(112, 20)
        Me.TXTGASTOSCUENTA.TabIndex = 102
        '
        'CBGASTOSVAR
        '
        Me.CBGASTOSVAR.Location = New System.Drawing.Point(268, 80)
        Me.CBGASTOSVAR.Name = "CBGASTOSVAR"
        Me.CBGASTOSVAR.Size = New System.Drawing.Size(184, 21)
        Me.CBGASTOSVAR.TabIndex = 3
        '
        'CBGASTOS
        '
        Me.CBGASTOS.Location = New System.Drawing.Point(12, 80)
        Me.CBGASTOS.Name = "CBGASTOS"
        Me.CBGASTOS.Size = New System.Drawing.Size(248, 21)
        Me.CBGASTOS.TabIndex = 2
        '
        'gbProveedorServiciosPagar
        '
        Me.gbProveedorServiciosPagar.Controls.Add(Me.GroupBox72)
        Me.gbProveedorServiciosPagar.Controls.Add(Me.GroupBox73)
        Me.gbProveedorServiciosPagar.Controls.Add(Me.GroupBox75)
        Me.gbProveedorServiciosPagar.Location = New System.Drawing.Point(8, 116)
        Me.gbProveedorServiciosPagar.Name = "gbProveedorServiciosPagar"
        Me.gbProveedorServiciosPagar.Size = New System.Drawing.Size(1000, 319)
        Me.gbProveedorServiciosPagar.TabIndex = 58
        Me.gbProveedorServiciosPagar.TabStop = False
        '
        'GroupBox72
        '
        Me.GroupBox72.Controls.Add(Me.cbBancoP)
        Me.GroupBox72.Controls.Add(Me.cbBancoPVar)
        Me.GroupBox72.Controls.Add(Me.Button54)
        Me.GroupBox72.Controls.Add(Me.txtBancoPNombre)
        Me.GroupBox72.Controls.Add(Me.txtBancoP)
        Me.GroupBox72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox72.Location = New System.Drawing.Point(488, 17)
        Me.GroupBox72.Name = "GroupBox72"
        Me.GroupBox72.Size = New System.Drawing.Size(464, 121)
        Me.GroupBox72.TabIndex = 47
        Me.GroupBox72.TabStop = False
        Me.GroupBox72.Text = "BANCOS"
        '
        'cbBancoP
        '
        Me.cbBancoP.Location = New System.Drawing.Point(12, 75)
        Me.cbBancoP.Name = "cbBancoP"
        Me.cbBancoP.Size = New System.Drawing.Size(248, 21)
        Me.cbBancoP.TabIndex = 7
        '
        'cbBancoPVar
        '
        Me.cbBancoPVar.Location = New System.Drawing.Point(268, 75)
        Me.cbBancoPVar.Name = "cbBancoPVar"
        Me.cbBancoPVar.Size = New System.Drawing.Size(184, 21)
        Me.cbBancoPVar.TabIndex = 8
        '
        'Button54
        '
        Me.Button54.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button54.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button54.Appearance.Options.UseFont = True
        Me.Button54.Appearance.Options.UseForeColor = True
        Me.Button54.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button54.Image = CType(resources.GetObject("Button54.Image"), System.Drawing.Image)
        Me.Button54.Location = New System.Drawing.Point(420, 26)
        Me.Button54.Name = "Button54"
        Me.Button54.Size = New System.Drawing.Size(32, 34)
        Me.Button54.TabIndex = 7
        '
        'txtBancoPNombre
        '
        Me.txtBancoPNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBancoPNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoPNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBancoPNombre.Location = New System.Drawing.Point(132, 34)
        Me.txtBancoPNombre.Name = "txtBancoPNombre"
        Me.txtBancoPNombre.ReadOnly = True
        Me.txtBancoPNombre.Size = New System.Drawing.Size(280, 20)
        Me.txtBancoPNombre.TabIndex = 100
        '
        'txtBancoP
        '
        Me.txtBancoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBancoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBancoP.Location = New System.Drawing.Point(12, 34)
        Me.txtBancoP.Name = "txtBancoP"
        Me.txtBancoP.ReadOnly = True
        Me.txtBancoP.Size = New System.Drawing.Size(112, 20)
        Me.txtBancoP.TabIndex = 100
        '
        'GroupBox73
        '
        Me.GroupBox73.Controls.Add(Me.cbIRP)
        Me.GroupBox73.Controls.Add(Me.cbIRPvar)
        Me.GroupBox73.Controls.Add(Me.Button55)
        Me.GroupBox73.Controls.Add(Me.txtIRPNombre)
        Me.GroupBox73.Controls.Add(Me.txtIRP)
        Me.GroupBox73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox73.Location = New System.Drawing.Point(216, 155)
        Me.GroupBox73.Name = "GroupBox73"
        Me.GroupBox73.Size = New System.Drawing.Size(464, 112)
        Me.GroupBox73.TabIndex = 46
        Me.GroupBox73.TabStop = False
        Me.GroupBox73.Text = "I.R."
        '
        'cbIRP
        '
        Me.cbIRP.Location = New System.Drawing.Point(12, 75)
        Me.cbIRP.Name = "cbIRP"
        Me.cbIRP.Size = New System.Drawing.Size(248, 21)
        Me.cbIRP.TabIndex = 10
        '
        'cbIRPvar
        '
        Me.cbIRPvar.Location = New System.Drawing.Point(268, 75)
        Me.cbIRPvar.Name = "cbIRPvar"
        Me.cbIRPvar.Size = New System.Drawing.Size(184, 21)
        Me.cbIRPvar.TabIndex = 11
        '
        'Button55
        '
        Me.Button55.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button55.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button55.Appearance.Options.UseFont = True
        Me.Button55.Appearance.Options.UseForeColor = True
        Me.Button55.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button55.Image = CType(resources.GetObject("Button55.Image"), System.Drawing.Image)
        Me.Button55.Location = New System.Drawing.Point(420, 32)
        Me.Button55.Name = "Button55"
        Me.Button55.Size = New System.Drawing.Size(32, 35)
        Me.Button55.TabIndex = 9
        '
        'txtIRPNombre
        '
        Me.txtIRPNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRPNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPNombre.Location = New System.Drawing.Point(140, 41)
        Me.txtIRPNombre.Name = "txtIRPNombre"
        Me.txtIRPNombre.ReadOnly = True
        Me.txtIRPNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtIRPNombre.TabIndex = 100
        '
        'txtIRP
        '
        Me.txtIRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRP.Location = New System.Drawing.Point(16, 41)
        Me.txtIRP.Name = "txtIRP"
        Me.txtIRP.ReadOnly = True
        Me.txtIRP.Size = New System.Drawing.Size(112, 20)
        Me.txtIRP.TabIndex = 100
        '
        'GroupBox75
        '
        Me.GroupBox75.Controls.Add(Me.Button57)
        Me.GroupBox75.Controls.Add(Me.txtProvPNombre)
        Me.GroupBox75.Controls.Add(Me.txtProvP)
        Me.GroupBox75.Controls.Add(Me.cbProvPVar)
        Me.GroupBox75.Controls.Add(Me.cbProvP)
        Me.GroupBox75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox75.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox75.Name = "GroupBox75"
        Me.GroupBox75.Size = New System.Drawing.Size(464, 121)
        Me.GroupBox75.TabIndex = 43
        Me.GroupBox75.TabStop = False
        Me.GroupBox75.Text = "PROVEEDOR"
        '
        'Button57
        '
        Me.Button57.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button57.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Button57.Appearance.Options.UseFont = True
        Me.Button57.Appearance.Options.UseForeColor = True
        Me.Button57.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button57.Image = CType(resources.GetObject("Button57.Image"), System.Drawing.Image)
        Me.Button57.Location = New System.Drawing.Point(420, 26)
        Me.Button57.Name = "Button57"
        Me.Button57.Size = New System.Drawing.Size(32, 34)
        Me.Button57.TabIndex = 101
        '
        'txtProvPNombre
        '
        Me.txtProvPNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvPNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProvPNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvPNombre.Location = New System.Drawing.Point(132, 34)
        Me.txtProvPNombre.Name = "txtProvPNombre"
        Me.txtProvPNombre.ReadOnly = True
        Me.txtProvPNombre.Size = New System.Drawing.Size(280, 20)
        Me.txtProvPNombre.TabIndex = 103
        '
        'txtProvP
        '
        Me.txtProvP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProvP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvP.Location = New System.Drawing.Point(12, 34)
        Me.txtProvP.Name = "txtProvP"
        Me.txtProvP.ReadOnly = True
        Me.txtProvP.Size = New System.Drawing.Size(112, 20)
        Me.txtProvP.TabIndex = 102
        '
        'cbProvPVar
        '
        Me.cbProvPVar.Location = New System.Drawing.Point(268, 80)
        Me.cbProvPVar.Name = "cbProvPVar"
        Me.cbProvPVar.Size = New System.Drawing.Size(184, 21)
        Me.cbProvPVar.TabIndex = 3
        '
        'cbProvP
        '
        Me.cbProvP.Location = New System.Drawing.Point(12, 80)
        Me.cbProvP.Name = "cbProvP"
        Me.cbProvP.Size = New System.Drawing.Size(248, 21)
        Me.cbProvP.TabIndex = 2
        '
        'frmTipoPlantillasAgregar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1228, 562)
        Me.Controls.Add(Me.gbxContado)
        Me.Controls.Add(Me.gbComprasCredito)
        Me.Controls.Add(Me.gbComprasContado)
        Me.Controls.Add(Me.gbProveedoresServicios)
        Me.Controls.Add(Me.gbReciboCaja)
        Me.Controls.Add(Me.gbAlcaldia)
        Me.Controls.Add(Me.gbCaja)
        Me.Controls.Add(Me.gbMttoValor)
        Me.Controls.Add(Me.gbProveedorServiciosPagar)
        Me.Controls.Add(Me.gbDepositoBancario)
        Me.Controls.Add(Me.gbImpuestos)
        Me.Controls.Add(Me.gbxIVA)
        Me.Controls.Add(Me.gbPagoProveedores)
        Me.Controls.Add(Me.gbPagoProductos)
        Me.Controls.Add(Me.gbReconexion)
        Me.Controls.Add(Me.gbxIR)
        Me.Controls.Add(Me.gbxCredito)
        Me.Controls.Add(Me.gbInstalacion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox52)
        Me.Controls.Add(Me.gbNotaDebito)
        Me.Controls.Add(Me.gbNotaCredito)
        Me.Controls.Add(Me.gbBlank)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTipoPlantillasAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Tipo de Plantillas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbPagoProveedores.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.gbInstalacion.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbReconexion.ResumeLayout(False)
        Me.gbCaja.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.gbxContado.ResumeLayout(False)
        Me.GroupBox76.ResumeLayout(False)
        Me.GroupBox76.PerformLayout()
        Me.GroupBox55.ResumeLayout(False)
        Me.GroupBox55.PerformLayout()
        Me.GroupBox53.ResumeLayout(False)
        Me.GroupBox53.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox80.ResumeLayout(False)
        Me.GroupBox80.PerformLayout()
        Me.gbxCredito.ResumeLayout(False)
        Me.GroupBox56.ResumeLayout(False)
        Me.GroupBox56.PerformLayout()
        Me.GroupBox62.ResumeLayout(False)
        Me.GroupBox62.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.gbxIVA.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.gbxIR.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox43.ResumeLayout(False)
        Me.GroupBox48.ResumeLayout(False)
        Me.GroupBox48.PerformLayout()
        Me.GroupBox49.ResumeLayout(False)
        Me.GroupBox49.PerformLayout()
        Me.GroupBox50.ResumeLayout(False)
        Me.GroupBox50.PerformLayout()
        Me.GroupBox51.ResumeLayout(False)
        Me.GroupBox51.PerformLayout()
        Me.gbReciboCaja.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox30.PerformLayout()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.gbDepositoBancario.ResumeLayout(False)
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout()
        Me.gbComprasContado.ResumeLayout(False)
        Me.GroupBox78.ResumeLayout(False)
        Me.GroupBox78.PerformLayout()
        Me.gbCCBanco.ResumeLayout(False)
        Me.gbCCBanco.PerformLayout()
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox33.PerformLayout()
        Me.GroupBox34.ResumeLayout(False)
        Me.GroupBox34.PerformLayout()
        Me.gbComprasCredito.ResumeLayout(False)
        Me.GroupBox79.ResumeLayout(False)
        Me.GroupBox79.PerformLayout()
        Me.GroupBox74.ResumeLayout(False)
        Me.GroupBox74.PerformLayout()
        Me.GroupBox36.ResumeLayout(False)
        Me.GroupBox36.PerformLayout()
        Me.gbImpuestos.ResumeLayout(False)
        Me.GroupBox42.ResumeLayout(False)
        Me.GroupBox42.PerformLayout()
        Me.GroupBox40.ResumeLayout(False)
        Me.GroupBox40.PerformLayout()
        Me.GroupBox41.ResumeLayout(False)
        Me.GroupBox41.PerformLayout()
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox31.PerformLayout()
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout()
        Me.GroupBox37.ResumeLayout(False)
        Me.GroupBox37.PerformLayout()
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox38.PerformLayout()
        Me.GroupBox39.ResumeLayout(False)
        Me.GroupBox39.PerformLayout()
        Me.gbNotaCredito.ResumeLayout(False)
        Me.GroupBox44.ResumeLayout(False)
        Me.GroupBox44.PerformLayout()
        Me.GroupBox47.ResumeLayout(False)
        Me.GroupBox47.PerformLayout()
        Me.gbNotaDebito.ResumeLayout(False)
        Me.GroupBox45.ResumeLayout(False)
        Me.GroupBox45.PerformLayout()
        Me.GroupBox46.ResumeLayout(False)
        Me.GroupBox46.PerformLayout()
        Me.GroupBox52.ResumeLayout(False)
        Me.GroupBox58.ResumeLayout(False)
        Me.GroupBox58.PerformLayout()
        Me.GroupBox59.ResumeLayout(False)
        Me.GroupBox59.PerformLayout()
        Me.GroupBox60.ResumeLayout(False)
        Me.GroupBox60.PerformLayout()
        Me.GroupBox61.ResumeLayout(False)
        Me.GroupBox61.PerformLayout()
        Me.gbAlcaldia.ResumeLayout(False)
        Me.GroupBox54.ResumeLayout(False)
        Me.GroupBox54.PerformLayout()
        Me.GroupBox57.ResumeLayout(False)
        Me.GroupBox57.PerformLayout()
        Me.gbMttoValor.ResumeLayout(False)
        Me.GroupBox64.ResumeLayout(False)
        Me.GroupBox64.PerformLayout()
        Me.gbexgreso.ResumeLayout(False)
        Me.gbexgreso.PerformLayout()
        Me.gbPagoProductos.ResumeLayout(False)
        Me.GroupBox65.ResumeLayout(False)
        Me.GroupBox65.PerformLayout()
        Me.GroupBox66.ResumeLayout(False)
        Me.GroupBox66.PerformLayout()
        Me.GroupBox67.ResumeLayout(False)
        Me.GroupBox67.PerformLayout()
        Me.gbProveedoresServicios.ResumeLayout(False)
        Me.GroupBox77.ResumeLayout(False)
        Me.GroupBox77.PerformLayout()
        Me.GroupBox70.ResumeLayout(False)
        Me.GroupBox70.PerformLayout()
        Me.GroupBox63.ResumeLayout(False)
        Me.GroupBox63.PerformLayout()
        Me.GroupBox68.ResumeLayout(False)
        Me.GroupBox68.PerformLayout()
        Me.GroupBox69.ResumeLayout(False)
        Me.GroupBox69.PerformLayout()
        Me.GroupBox71.ResumeLayout(False)
        Me.GroupBox71.PerformLayout()
        Me.gbProveedorServiciosPagar.ResumeLayout(False)
        Me.GroupBox72.ResumeLayout(False)
        Me.GroupBox72.PerformLayout()
        Me.GroupBox73.ResumeLayout(False)
        Me.GroupBox73.PerformLayout()
        Me.GroupBox75.ResumeLayout(False)
        Me.GroupBox75.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Private WithEvents myDataSet As DataSet
    Dim WithEvents tCust As DataTable
    Dim WithEvents Cuenta As DataGridTextBoxColumn
    Dim WithEvents Usos As DataGridTextBoxColumn
    Dim WithEvents Catalogo As DataGridTextBoxColumn
    Dim WithEvents DC As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto4 As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID4 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var4 As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID4 As DataGridTextBox.DataGridComboBox
    Dim CatalogoDB As New VB.SysContab.CatalogoDB
    Dim ConceptoDB As New VB.SysContab.ConceptosDB
    Dim VariablesDB As New VB.SysContab.VariablesDB
    Dim Plantilla As New VB.SysContab.PlantillaDB
    Dim Comprobantes As New VB.SysContab.ComprobanteDB
    Dim r As New VB.SysContab.Rutinas
    Dim i As Integer
#End Region


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Validar() = True Then


            If cbEsquema.SelectedValue.ToString = 10 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try


                    ' Agregar IR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRP.Text, _
                                                "I.R.", 2, cbIRP.SelectedValue, Me.cbIRPvar.SelectedValue, _
                                                "", "", "", "", "", "")


                    ' Agregar PROVEEDORES
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtProvP.Text, _
                                               "PROVEEDORES", 1, cbProvP.SelectedValue, cbProvPVar.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar BANCOS
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtBancoP.Text, _
                                               "BANCOS", 2, Me.cbBancoP.SelectedValue, Me.cbBancoPVar.SelectedValue, _
                                                "", "", "", "", "", "")


                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")

                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()

                    'Dim f As frmPlantillasBuscar = f.Instance
                    'f.dgZonas.DataSource = Plantilla.GetList().Tables("Tablas").DefaultView
                    Me.Close()
                End Try



            End If



            If cbEsquema.SelectedValue.ToString = 9 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try


                    ' Agregar BANCOS
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, TXTGASTOSCUENTA.Text, _
                                               "Bancos", 1, CBGASTOS.SelectedValue, CBGASTOSVAR.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar IVA X COBRAR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.TXTIVAXCOBRAR.Text, _
                                               "I.V.A x COBRAR", 1, Me.CBIVAPORCOBRAR.SelectedValue, Me.CBIVAPORCOBRARVAR.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar Proveedores
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, TXTPROVEEDORCUENTA.Text, _
                                                "Proveedores", 2, CBPROVEEDOR.SelectedValue, CBPROVEEDORVAR.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar IR X COBRAR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.TXTIRXPAGARCUENTA.Text, _
                                               "I.R. x COBRAR", 2, Me.CBIRXPAGAR.SelectedValue, Me.CBIRXPAGARVAR.SelectedValue, _
                                                "", "", "", "", "", "")


                    ' Agregar IR X COBRAR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRxPagarC.Text, _
                                                "I.R. x COBRAR", 2, Me.cbIRxPagarC.SelectedValue, Me.cbIRxPagarV.SelectedValue, _
                                                 "", "", "", "", "", "")

                    ' Agregar IR ALCALDIA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRPagoAlcCuenta.Text, _
                                                "I.R. x Pagar Alcaldia", 2, Me.cbIRxPagAlcC.SelectedValue, Me.cbIRxPagAlcVar.SelectedValue, _
                                                 "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()

                    'Dim f As frmPlantillasBuscar = f.Instance
                    'f.dgZonas.DataSource = Plantilla.GetList().Tables("Tablas").DefaultView
                    Me.Close()

                End Try



            End If


            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try
                    ' Agregar Proveedores
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVACuenta.Text, _
                                                "Proveedores", 1, CbProvC.SelectedValue, CbProvVar.SelectedValue, _
                                                "", "", "", "", "", "")
                    ' Agregar Bancos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVACuenta.Text, _
                                               "Bancos", 2, cbBanC.SelectedValue, cbBancVar.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVACuenta.Text, _
                                           "I.V.A.", 1, cbIVAC.SelectedValue, CbIVAVar.SelectedValue, _
                                            "", "", "", "", "", "")

                    ' Agregar IR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIRCuenta.Text, _
                                               "I.R.", 2, CbIRC.SelectedValue, CbIRVar.SelectedValue, _
                                                "", "", "", "", "", "")
                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try

            End If


            ' Pago de Proveedores Productos
            If cbEsquema.SelectedValue.ToString = 8 And cbTipoProv.SelectedValue.ToString = 10 Then
                Try

                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtProdIVACta.Text, _
                                           "I.R.", 2, cbIVAProdC.SelectedValue, cbIVAProdVar.SelectedValue, _
                                             "", "", "", "", "", "")

                    ' Agregar Proveedores
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtProdProvCta.Text, _
                                                "Proveedores", 1, cbProvProdC.SelectedValue, cbProvProdVar.SelectedValue, _
                                                "", "", "", "", "", "")
                    ' Agregar Bancos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtProdBancos.Text, _
                                               "Bancos", 2, cBancosProdC.SelectedValue, cBancosProdVar.SelectedValue, _
                                                "", "", "", "", "", "")




                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try

            End If


            ' mtto valor
            If cbEsquema.SelectedValue.ToString = 7 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try
                    ' Agregar ingreso matto valor
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIngresoMtto.Text, _
                                           "Ingreso por Matto Valor", 2, "0", "", _
                                            "", "", "", "", "", "")

                    ' Agregar egreso matto valor
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtEgresoMtto.Text, _
                                           "Egreso por Matto Valor", 1, "0", "", _
                                            "", "", "", "", "", "")
                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try

            End If
            ' INSTALACION
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 2 Then
                Try
                    ' Agregar DEPOSITO EN GARANTIA 
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtDepCuenta.Text, _
                                           "Deposito en Garantia", 1, cbDeptC.SelectedValue, cbDeptVar.SelectedValue, _
                                            "", "", "", "", "", "")

                    ' Agregar Bancos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtDepCuenta.Text, _
                                               "Bancos", 2, cbBancos.SelectedValue, cbBancosVar.SelectedValue, _
                                                "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try

            End If

            ' RECONEXION
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 3 Then
                Try

                    ' Agregar Proveedores
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtRecoCuenta.Text, _
                                                "Proveedores", 1, cbProvReco.SelectedValue, cbProvVarReco.SelectedValue, _
                                                "", "", "", "", "", "")
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtRecoCuenta.Text, _
                                           "I.V.A. Reconexión", 1, cbRecoC.SelectedValue, cbRecoVar.SelectedValue, _
                                            "", "", "", "", "", "")
                    ' Agregar Bancos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtRecoCuenta.Text, _
                                               "Bancos", 2, cbBancoReco.SelectedValue, cbBancoVarReco.SelectedValue, _
                                                "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If

            ' DEPOSITOS DE PROVEEDORES
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 4 Then
                Try
                    ' Agregar Proveedor
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Proveedor", 1, cbCajaConcep.SelectedValue, cbCajaVar.SelectedValue, _
                                                "", "", "", "", "", "")
                    'Caja o Banco
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Caja", 2, cbCajaConcep.SelectedValue, cbCajaVar.SelectedValue, _
                                                "", "", "", "", "", "")
                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try

            End If

            ' ABONO
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 5 Then
                Try

                    ' Agregar Proveedor
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Proveedor", 1, cbCajaConcep.SelectedValue, cbCajaVar.SelectedValue, _
                                                "", "", "", "", "", "")

                    'Caja o Banco
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Banco", 2, cbCajaConcep.SelectedValue, cbCajaVar.SelectedValue, _
                                                "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try

            End If

            ' NOTA DE DEBITO
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 6 Then
                Try
                    ' Agregar Proveedor
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Proveedor", 1, cbCajaConcep.SelectedValue, cbCajaVar.SelectedValue, _
                                                "", "", "", "", "", "")

                    'Caja o Banco
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Banco", 2, cbCajaConcep.SelectedValue, cbCajaVar.SelectedValue, _
                                                "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If

            ' I.V.A
            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try
                    ' Agregar IVA Soportado
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVASoport.Text, _
                                                "I.V.A.", 1, 0, 0, _
                                                "", "", "", "", "", "")
                    ' Agregar IVA Repercutido
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVAReper.Text, _
                                           "I.V.A.", 2, 0, 0, _
                                            "", "", "", "", "", "")

                    ' Agregar CAJA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, _txtCajaIVA.Text, _
                                           "Caja", 2, 0, 0, _
                                            "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If

            ' I.R.
            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 2 Then
                Try
                    ' Agregar I.R. S/ Venta
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIRVent.Text, _
                                                "I.R. sobre Ventas", 1, 0, 0, _
                                                "", "", "", "", "", "")
                    ' Agregar I.R Adelantado Bienes
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIRPag.Text, _
                                           "I.R. pagado x adelantado bienes", 2, 0, 0, _
                                            "", "", "", "", "", "")

                    ' Agregar I.R Adelantado Servicios
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIRPagServ.Text, _
                                           "I.R. pagado x adelantado servicios", 2, 0, 0, _
                                            "", "", "", "", "", "")

                    ' Agregar CAJA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaIR.Text, _
                                           "Caja", 2, 0, 0, _
                                            "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try

            End If

            ' VENTAS DE CONTADO
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try
                    ' Agregar CAJA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuentaContado.Text, _
                                               "Caja", 1, cbCajaConcepto.SelectedValue, cbCajaVariable.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar IR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRContadoCodigo.Text, _
                                               "IR", 1, Me.cbIRContadoConcepto.SelectedValue, Me.cbIRContadoVariable.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar Ingresos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIngrCuenta.Text, _
                                                "Ingresos", 2, cbIngrConceptos.SelectedValue, cbIngrVariable.SelectedValue, _
                                                "", "", "", "", "", "")
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVACuentaIngr.Text, _
                                           "I.V.A.", 2, cbConceptoIVAIngr.SelectedValue, cbVarIVAIngr.SelectedValue, _
                                            "", "", "", "", "", "")


                    ' Agregar Costo de Ventas
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCostoVentaCuentaIngr.Text, _
                                            "Costo de Ventas", 1, Me.cbConceptoCostoVentaIngr.SelectedValue, Me.cbVarCostoVentaIngr.SelectedValue, _
                                                 "", "", "", "", "", "")


                    ' Agregar Inventario
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtInventarioCuentaIngr.Text, _
                                            "Inventario", 2, Me.cbInventarioVentaIngr.SelectedValue, Me.cbVarInventarioIngr.SelectedValue, _
                                                 "", "", "", "", "", "")

                    ' Agregar IR Alcaldia s/ventas
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRAlcCuenta.Text, _
                                            "IR. Alcaldia", 2, Me.cbIRAlcConcepto.SelectedValue, Me.cbIRAlcVariable.SelectedValue, _
                                                  "", "", "", "", "", "")

                    ' Agregar Devolucion
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtdevolucioncuenta.Text, _
                                            "Devolucion", 2, Me.cbdevolucionconcepto.SelectedValue, Me.cbdevolucionvariable.SelectedValue, _
                                                  "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try
            End If

            ' VENTAS DE CREDITO
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 2 Then
                Try

                    '' Clientes
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtClienteCodigo.Text, _
                    '                            "Cliente", 1, Me.cbClienteConcepto.SelectedValue, Me.cbClienteVariable.SelectedValue, _
                    '                            "", "", "", "", "", "")

                    '' IR
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRCreditoCodigo.Text, _
                    '                            "IR", 1, Me.cbIrCreditoConcepto.SelectedValue, Me.cbIRCreditoVariable.SelectedValue, _
                    '                            "", "", "", "", "", "")

                    ' Agregar Ingresos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCuentaCred.Text, _
                                                "Ingresos", 2, Me.cbIngresoCreditoConcepto.SelectedValue, Me.cbIngresoCreditoVariable.SelectedValue, _
                                                "", "", "", "", "", "")
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVACred.Text, _
                                           "I.V.A.", 2, Me.cbIvaCreditoConcepto.SelectedValue, Me.cbIvaCreditoVariable.SelectedValue, _
                                            "", "", "", "", "", "")

                    ' Agregar Costo de Ventas
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCuentaCostoCred.Text, _
                                            "Costo de Ventas", 1, Me.cbIngresoCreditoCostoConcepto.SelectedValue, Me.cbIngresoCreditoCostoVariable.SelectedValue, _
                                                 "", "", "", "", "", "")


                    ' Agregar Inventario
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtInventarioCred.Text, _
                                            "Inventario", 2, Me.cbInventarioConcepto.SelectedValue, Me.cbInventarioVariable.SelectedValue, _
                                                 "", "", "", "", "", "")



                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If

            ' NOTAS DE CREDITO
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 4 Then
                Try
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtNCIvaCodigo.Text, _
                                           "I.V.A.", 1, "", "", _
                                            "", "", "", "", "", "")

                    ' Agregar CAJA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtNCCajaCodigo.Text, _
                                           "Caja", 2, "", "", _
                                            "", "", "", "", "", "")


                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If


            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 7 Then
                Try
                    For i = 0 To tCust.Rows.Count - 1

                        Dim DC As String
                        Dim Opera As Integer

                        If tCust.Rows(i)("DC").ToString = "Débito" Then
                            DC = "D"
                            Opera = 1
                        End If

                        If tCust.Rows(i)("DC").ToString = "Crédito" Then
                            DC = "C"
                            Opera = 2
                        End If

                        Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, tCust.Rows(i)("Cuenta").ToString, _
                                                    tCust.Rows(i)("Uso").ToString, Opera, _
                                                    tCust.Rows(i)("ConceptoID").ToString, tCust.Rows(i)("VarID").ToString, _
                                                    tCust.Rows(i)("ConceptoID2").ToString, tCust.Rows(i)("VarID2").ToString, _
                                                    tCust.Rows(i)("ConceptoID3").ToString, tCust.Rows(i)("VarID3").ToString, _
                                                    tCust.Rows(i)("ConceptoID4").ToString, tCust.Rows(i)("VarID4").ToString)

                    Next

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try

            End If

            ' DEPOSITOS EN CAJA
            If cbEsquema.SelectedValue.ToString = 5 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try

                    ' Agregar Bancos
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuenta.Text, _
                                               "Caja", 2, 0, 0, _
                                                "", "", "", "", "", "")
                    '' Moneda Nacional
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtMoneda1Cuenta.Text, _
                    '                            "Moneda Nacional", 1, Me.cbMoneda1Concepto.SelectedValue, Me.cbMoneda1Variable.SelectedValue, _
                    '                            "", "", "", "", "", "")

                    '' Moneda Extranjera
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtMoneda2Cuenta.Text, _
                    '                            "Moneda Extranjera", 1, Me.cbMoneda2Concepto.SelectedValue, Me.cbMoneda2Variable.SelectedValue, _
                    '                            "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If

            'ABONO DE CLIENTE - Recibo de Caja
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 3 Then
                Try
                    ' Agregar CAJA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtCajaCodigo.Text, _
                                               "Caja", 1, Me.cbCajaConcepto1.SelectedValue, Me.cbCajaVariable1.SelectedValue, _
                                                "", "", "", "", "", "")

                    ' Agregar IR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtReciboIRCuenta.Text, _
                                               "IR", 1, Me.cbReciboIRConcepto.SelectedValue, Me.cbReciboIRVariable.SelectedValue, _
                                                "", "", "", "", "", "")

                    '' Agregar IR ALCADIA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtReciboIvaCuenta.Text, _
                                               "IR Alcadia", 2, Me.cbReciboIRConcepto.SelectedValue, Me.cbReciboIRVariable.SelectedValue, _
                                                "", "", "", "", "", "")

                    '' Agregar Banco
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtBancoCodigo.Text, _
                    '                           "Banco", 1, Me.cbBancoConcepto.SelectedValue, Me.cbBancoVariable.SelectedValue, _
                    '                            "", "", "", "", "", "")

                    '' Agregar Ingresos
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIngrCuenta.Text, _
                    '                            "Ingresos", 2, cbIngrConceptos.SelectedValue, cbIngrVariable.SelectedValue, _
                    '                            "", "", "", "", "", "")
                    '' Agregar IVA
                    'Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIVACuentaIngr.Text, _
                    '                       "I.V.A.", 2, cbConceptoIVAIngr.SelectedValue, cbVarIVAIngr.SelectedValue, _
                    '                        "", "", "", "", "", "")
                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If


            ' COMPRAS DE CONTADO
            If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 1 Then
                Try
                    '''' Agregar CAJA
                    ''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtCajaCuentaContado.Text, _
                    ''                           "Caja", 1, cbCajaConcepto.SelectedValue, cbCajaVariable.SelectedValue, _
                    ''                            "", "", "", "", "", "")

                    ' Agregar IR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRCCCodigo.Text, _
                                               "IR", 2, Me.cbIRCCConcepto.SelectedValue, Me.cbIRCCVariable.SelectedValue, _
                                                "", "", "", "", "", "")

                    '''' Agregar Ingresos
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIngrCuenta.Text, _
                    '''                            "Ingresos", 2, cbIngrConceptos.SelectedValue, cbIngrVariable.SelectedValue, _
                    '''                            "", "", "", "", "", "")
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIvaCCCodigo.Text, _
                                           "I.V.A.", 1, Me.cbIvaCCConcepto.SelectedValue, Me.cbIvaCCVariable.SelectedValue, _
                                            "", "", "", "", "", "")

                    ' Agregar BANCO
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtccCuenta.Text, _
                                               "Banco", 1, Me.cbccConcepto.SelectedValue, Me.cbccVariable.SelectedValue, _
                                                 "", "", "", "", "", "")


                    ' Agregar I.R Alcaldia
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRCompContCuenta.Text, _
                                               "I.R. Alcaldia", 2, Me.cbIRCompContConcep.SelectedValue, Me.cbIRCompContVar.SelectedValue, _
                                                 "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try
            End If

            ' COMPRAS DE CREDITO
            If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 2 Then
                Try
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIvaCCredCodigo.Text, _
                                           "I.V.A.", 1, Me.cbIvaCCredConcepto.SelectedValue, Me.cbIvaCCredVariable.SelectedValue, _
                                            "", "", "", "", "", "")

                    ' Agregar IR
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtIRCompraCredC.Text, _
                                           "I.R.", 2, cbCompraCredConcep.SelectedValue, Me.cbCompraCredVar.SelectedValue, _
                                            "", "", "", "", "", "")


                    ' Agregar IR ALCALDIA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRAlcCompCredCuenta.Text, _
                                           "I.R. ALCALDIA", 2, Me.cbIRAlcCompCredConcepto.SelectedValue, Me.cbIRAlcCompCredVar.SelectedValue, _
                                            "", "", "", "", "", "")


                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try
            End If

            ' NOTAS DE DEBITO
            If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 3 Then
                Try
                    ' Agregar IVA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtNDIvaCodigo.Text, _
                                           "I.V.A.", 2, "", "", _
                                            "", "", "", "", "", "")

                    ' Agregar CAJA
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, txtNDCajaCodigo.Text, _
                                           "Caja", 1, "", "", _
                                            "", "", "", "", "", "")


                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()
                End Try
            End If

            ' IMPUESTOS IR, IVA
            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 3 Then
                Try
                    ' IR Anticipo
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRAnticipoCodigo.Text, _
                                           "IR Anticipo", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' IR por Pagar
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRxPCodigo.Text, _
                                           "IR Por Pagar", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' IR Servicios Profesionales
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRSPCodigo.Text, _
                                           "IR Servicios Profesionales", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' IR Sobre Residente
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRSRCodigo.Text, _
                                           "IR Residentes Profesionales", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' IR Salario
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRSalarioCodigo.Text, _
                                           "IR Salario", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' IVA Soportado
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIva1Codigo.Text, _
                                           "IVA Soportado", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' IVA Repercutido
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIva2Codigo.Text, _
                                           "IVA Repercutido", 2, 0, "", _
                                            "", "", "", "", "", "")

                    ' Caja General
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtCajaImpCodigo.Text, _
                                           "Caja General", 2, 0, "", _
                                            "", "", "", "", "", "")

                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try
            End If






            ' IMPUESTOS ALCALDIA
            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 4 Then
                Try
                    '''' IR Anticipo
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRAnticipoCodigo.Text, _
                    '''                       "IR Anticipo", 1, 0, "", _
                    '''                        "", "", "", "", "", "")

                    '''' IR por Pagar
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRxPCodigo.Text, _
                    '''                       "IR Por Pagar", 1, 0, "", _
                    '''                        "", "", "", "", "", "")

                    '''' IR Servicios Profesionales
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRSPCodigo.Text, _
                    '''                       "IR Servicios Profesionales", 1, 0, "", _
                    '''                        "", "", "", "", "", "")

                    '''' IR Sobre Residente
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRSRCodigo.Text, _
                    '''                       "IR Residentes Profesionales", 1, 0, "", _
                    '''                        "", "", "", "", "", "")

                    '''' IR Salario
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIRSalarioCodigo.Text, _
                    '''                       "IR Salario", 1, 0, "", _
                    '''                        "", "", "", "", "", "")

                    '''' IVA Soportado
                    '''Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtIva1Codigo.Text, _
                    '''                       "IVA Soportado", 1, 0, "", _
                    '''                        "", "", "", "", "", "")

                    ' Alcaldia
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtAlcaldiaCodigo.Text, _
                                           "Impuesto Alcaldia", 1, 0, "", _
                                            "", "", "", "", "", "")

                    ' Caja General
                    Plantilla.AddTipoPlantilla(txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue, cbTipoProv.SelectedValue, cbEsquema.SelectedValue, Me.txtAlcaldiaCajaCodigo.Text, _
                                           "Caja General", 2, 0, "", _
                                            "", "", "", "", "", "")


                Catch Mensaje As Exception
                    MsgBox(Mensaje.Message)
                    Exit Sub
                Finally
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                End Try
            End If

        End If
    End Sub

    Private Sub frmAgregarZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTipo.Focus()

        MakeDataSet()
        dgFacturacionCliente.SetDataBinding(myDataSet, "Plantillas")
        AddCustomDataTableStyle()

        cbTipoComp.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
        cbTipoComp.ValueMember = "TipComp_Id"
        cbTipoComp.DisplayMember = "TipComp_Nombre"

        cbEsquema.DataSource = Plantilla.GetListPlantillasContables().Tables("Tablas")
        cbEsquema.ValueMember = "Pla_Id"
        cbEsquema.DisplayMember = "Pla_Nombre"

        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Plantillas")

        ' Create two columns, and add them to the first table.

        Dim cCuenta As DataColumn
        cCuenta = New DataColumn("Cuenta")

        Dim cCatalogo As DataColumn
        cCatalogo = New DataColumn("Catalogo")

        Dim cUso As DataColumn
        cUso = New DataColumn("Uso")

        Dim cDC As DataColumn
        cDC = New DataColumn("DC")

        Dim cConcepto As DataColumn
        cConcepto = New DataColumn("Concepto")

        Dim cConceptoID As DataColumn
        cConceptoID = New DataColumn("ConceptoID")

        Dim cVar As DataColumn
        cVar = New DataColumn("Var")

        Dim cVarID As DataColumn
        cVarID = New DataColumn("VarID")

        Dim cConcepto2 As DataColumn
        cConcepto2 = New DataColumn("Concepto2")

        Dim cConceptoID2 As DataColumn
        cConceptoID2 = New DataColumn("ConceptoID2")

        Dim cVar2 As DataColumn
        cVar2 = New DataColumn("Var2")

        Dim cVarID2 As DataColumn
        cVarID2 = New DataColumn("VarID2")

        Dim cConcepto3 As DataColumn
        cConcepto3 = New DataColumn("Concepto3")

        Dim cConceptoID3 As DataColumn
        cConceptoID3 = New DataColumn("ConceptoID3")

        Dim cVar3 As DataColumn
        cVar3 = New DataColumn("Var3")

        Dim cVarID3 As DataColumn
        cVarID3 = New DataColumn("VarID3")

        Dim cConcepto4 As DataColumn
        cConcepto4 = New DataColumn("Concepto4")

        Dim cConceptoID4 As DataColumn
        cConceptoID4 = New DataColumn("ConceptoID4")

        Dim cVar4 As DataColumn
        cVar4 = New DataColumn("Var4")

        Dim cVarID4 As DataColumn
        cVarID4 = New DataColumn("VarID4")

        tCust.Columns.Add(cCuenta)
        tCust.Columns.Add(cCatalogo)
        tCust.Columns.Add(cUso)
        tCust.Columns.Add(cDC)
        tCust.Columns.Add(cConcepto)
        tCust.Columns.Add(cConceptoID)
        tCust.Columns.Add(cVar)
        tCust.Columns.Add(cVarID)
        tCust.Columns.Add(cConcepto2)
        tCust.Columns.Add(cConceptoID2)
        tCust.Columns.Add(cVar2)
        tCust.Columns.Add(cVarID2)
        tCust.Columns.Add(cConcepto3)
        tCust.Columns.Add(cConceptoID3)
        tCust.Columns.Add(cVar3)
        tCust.Columns.Add(cVarID3)
        tCust.Columns.Add(cConcepto4)
        tCust.Columns.Add(cConceptoID4)
        tCust.Columns.Add(cVar4)
        tCust.Columns.Add(cVarID4)

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow
    End Sub

    Private Sub AddCustomDataTableStyle()
        Dim dsItems As DataSet
        dsItems = ConceptoDB.GetList()

        Dim dsVariables As DataSet
        dsVariables = VariablesDB.GetList()

        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle
        ts1.MappingName = "Plantillas"
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        ' Cuenta
        Cuenta = New DataGridTextBoxColumn
        Cuenta.MappingName = "Cuenta"
        Cuenta.HeaderText = "Cuenta"
        Cuenta.Width = 100
        Cuenta.ReadOnly = False
        ts1.GridColumnStyles.Add(Cuenta)
        ts1.PreferredRowHeight = (Cuenta.TextBox.Height + 3)
        Cuenta.NullText = ""
        colCount = (colCount + 1)
        AddHandler Cuenta.TextBox.DoubleClick, New EventHandler(AddressOf ObtieneDato2)

        ' CATALOGO
        Catalogo = New DataGridTextBoxColumn
        Catalogo.MappingName = "Catalogo"
        Catalogo.HeaderText = "Catalogo"
        Catalogo.Width = 200
        Catalogo.ReadOnly = True
        ts1.GridColumnStyles.Add(Catalogo)
        ts1.PreferredRowHeight = (Catalogo.TextBox.Height + 3)
        Catalogo.NullText = ""
        colCount = (colCount + 1)

        ' Etiqueta
        Usos = New DataGridTextBoxColumn
        Usos.MappingName = "Uso"
        Usos.HeaderText = "Etiqueta"
        Usos.Width = 200
        Usos.ReadOnly = False
        ts1.GridColumnStyles.Add(Usos)
        ts1.PreferredRowHeight = (Usos.TextBox.Height + 3)
        Usos.NullText = ""
        colCount = (colCount + 1)

        ' DEBITO / CREDITO --- 0 / 1 
        DC = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboCredito))
        DC.MappingName = "DC"
        DC.HeaderText = "Débito/Crédito"
        DC.Width = 150
        DC.Alignment = HorizontalAlignment.Center
        DC.ReadOnly = True
        DC.ColumnComboBox.Items.Add("Débito")
        DC.ColumnComboBox.Items.Add("Crédito")

        ts1.GridColumnStyles.Add(DC)
        colCount = (colCount + 1)
        DC.NullText = "-Seleccione-"

        'CONCEPTO ID 
        ConceptoID = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto))
        ConceptoID.MappingName = "ConceptoID"
        ConceptoID.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID)
        ts1.PreferredRowHeight = (ConceptoID.ColumnComboBox.Height + 3)
        ConceptoID.NullText = ""
        colCount = (colCount + 1)

        ' CONCEPTO
        Concepto = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto))
        Concepto.MappingName = "Concepto"
        Concepto.HeaderText = "Concepto"
        Concepto.Width = 200
        Concepto.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto)
        ts1.PreferredRowHeight = (Concepto.TextBox.Height + 3)
        Concepto.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)

        'Variables ID 
        VarID = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar))
        VarID.MappingName = "VarID"
        VarID.Width = 0
        ts1.GridColumnStyles.Add(VarID)
        ts1.PreferredRowHeight = (VarID.ColumnComboBox.Height + 3)
        VarID.NullText = ""
        colCount = (colCount + 1)

        ' Variables
        Var = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar))
        Var.MappingName = "Var"
        Var.HeaderText = "Variable1"
        Var.Width = 200
        Var.ReadOnly = True
        ts1.GridColumnStyles.Add(Var)
        ts1.PreferredRowHeight = (Var.TextBox.Height + 3)
        Var.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)

        'CONCEPTO ID 2
        ConceptoID2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto2))
        ConceptoID2.MappingName = "ConceptoID2"
        ConceptoID2.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID2)
        ts1.PreferredRowHeight = (ConceptoID2.ColumnComboBox.Height + 3)
        ConceptoID2.NullText = ""
        colCount = (colCount + 1)

        ' CONCEPTO 2
        Concepto2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto2))
        Concepto2.MappingName = "Concepto2"
        Concepto2.HeaderText = "Concepto2"
        Concepto2.Width = 200
        Concepto2.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto2)
        ts1.PreferredRowHeight = (Concepto2.TextBox.Height + 3)
        Concepto2.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID2.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto2.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)

        'Variables ID2 
        VarID2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar2))
        VarID2.MappingName = "VarID2"
        VarID2.Width = 0
        ts1.GridColumnStyles.Add(VarID2)
        ts1.PreferredRowHeight = (VarID2.ColumnComboBox.Height + 3)
        VarID2.NullText = ""
        colCount = (colCount + 1)

        ' Variables2
        Var2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar2))
        Var2.MappingName = "Var2"
        Var2.HeaderText = "Variable2"
        Var2.Width = 200
        Var2.ReadOnly = True
        ts1.GridColumnStyles.Add(Var2)
        ts1.PreferredRowHeight = (Var2.TextBox.Height + 3)
        Var2.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID2.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var2.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)

        'CONCEPTO ID 3
        ConceptoID3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto3))
        ConceptoID3.MappingName = "ConceptoID3"
        ConceptoID3.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID3)
        ts1.PreferredRowHeight = (ConceptoID3.ColumnComboBox.Height + 3)
        ConceptoID3.NullText = ""
        colCount = (colCount + 1)

        ' CONCEPTO 3
        Concepto3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto3))
        Concepto3.MappingName = "Concepto3"
        Concepto3.HeaderText = "Concepto3"
        Concepto3.Width = 200
        Concepto3.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto3)
        ts1.PreferredRowHeight = (Concepto3.TextBox.Height + 3)
        Concepto3.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID3.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto3.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)

        'Variables ID3 
        VarID3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar3))
        VarID3.MappingName = "VarID3"
        VarID3.Width = 0
        ts1.GridColumnStyles.Add(VarID3)
        ts1.PreferredRowHeight = (VarID3.ColumnComboBox.Height + 3)
        VarID3.NullText = ""
        colCount = (colCount + 1)

        ' Variables3
        Var3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar3))
        Var3.MappingName = "Var3"
        Var3.HeaderText = "Variable3"
        Var3.Width = 200
        Var3.ReadOnly = True
        ts1.GridColumnStyles.Add(Var3)
        ts1.PreferredRowHeight = (Var3.TextBox.Height + 3)
        Var3.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID3.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var3.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)

        'CONCEPTO ID 4
        ConceptoID4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto4))
        ConceptoID4.MappingName = "ConceptoID4"
        ConceptoID4.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID4)
        ts1.PreferredRowHeight = (ConceptoID4.ColumnComboBox.Height + 3)
        ConceptoID4.NullText = ""
        colCount = (colCount + 1)

        ' CONCEPTO 4
        Concepto4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto4))
        Concepto4.MappingName = "Concepto4"
        Concepto4.HeaderText = "Concepto4"
        Concepto4.Width = 200
        Concepto4.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto4)
        ts1.PreferredRowHeight = (Concepto4.TextBox.Height + 3)
        Concepto4.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID4.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto4.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)

        'Variables ID4
        VarID4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar4))
        VarID4.MappingName = "VarID4"
        VarID4.Width = 0
        ts1.GridColumnStyles.Add(VarID4)
        ts1.PreferredRowHeight = (VarID4.ColumnComboBox.Height + 3)
        VarID4.NullText = ""
        colCount = (colCount + 1)

        ' Variables4
        Var4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar4))
        Var4.MappingName = "Var4"
        Var4.HeaderText = "Variable4"
        Var4.Width = 200
        Var4.ReadOnly = True
        ts1.GridColumnStyles.Add(Var4)
        ts1.PreferredRowHeight = (Var4.TextBox.Height + 3)
        Var4.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID4.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var4.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)

        ts1.AllowSorting = False
        ts1.HeaderFont = dgFacturacionCliente.HeaderFont
        dgFacturacionCliente.CaptionVisible = False
        dgFacturacionCliente.TableStyles.Clear()
        dgFacturacionCliente.TableStyles.Add(ts1)
    End Sub

    Public Sub MyComboCredito(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("DC") = DC.ColumnComboBox.Items.Item(Indice)

                Else
                    tCust.Rows(rowChanging)("DC") = DC.ColumnComboBox.Items.Item(Indice)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboCredito")
        End Try
    End Sub

    Public Sub MyComboConcepto(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID") = ConceptoID.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto") = Concepto.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID") = ConceptoID.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto") = Concepto.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboCredito")
        End Try
    End Sub


    Public Sub MyComboVar(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID") = VarID.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var") = Var.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID") = VarID.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var") = Var.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar")
        End Try
    End Sub

    Public Sub MyComboConcepto2(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID2") = ConceptoID2.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto2") = Concepto2.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID2") = ConceptoID2.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto2") = Concepto2.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboConcepto2")
        End Try
    End Sub

    Public Sub MyComboVar2(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID2") = VarID2.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var2") = Var2.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID2") = VarID2.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var2") = Var2.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar2")
        End Try
    End Sub

    Public Sub MyComboConcepto3(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID3") = ConceptoID3.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto3") = Concepto3.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID3") = ConceptoID3.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto3") = Concepto3.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboConcepto3")
        End Try
    End Sub

    Public Sub MyComboVar3(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID3") = VarID3.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var3") = Var3.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID3") = VarID3.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var3") = Var3.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar3")
        End Try
    End Sub

    Public Sub MyComboConcepto4(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID4") = ConceptoID4.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto4") = Concepto4.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID4") = ConceptoID4.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto4") = Concepto4.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboConcepto2")
        End Try
    End Sub

    Public Sub MyComboVar4(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID4") = VarID4.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var4") = Var4.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID4") = VarID4.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var4") = Var4.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar4")
        End Try
    End Sub

    Private Sub ObtieneDato2(ByVal sender As Object, ByVal e As EventArgs)
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If tCust.Rows.Count < Me.dgFacturacionCliente.CurrentRowIndex + 1 Then
            Dim newRow1 As DataRow
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)
            newRow1("Cuenta") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            newRow1("Catalogo") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Cuenta") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Catalogo") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        End If
    End Sub

    Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.F3 Then
            ObtieneDato2(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then

        End If

    End Sub

    Private Function Validar() As Boolean

        Dim Credito As Integer = 0
        Dim Debito As Integer = 0
        Dim MontActivo As Double = 0
        Dim MontPasivo As Double = 0

        If Trim(txtTipo.Text) = "" Then
            MsgBox("Introduzca el Tipo de Plantilla", MsgBoxStyle.Information)
            txtTipo.Focus()
            txtTipo.SelectAll()
            Return False
            Exit Function
        End If

        If Plantilla.ValidaTipo(txtTipo.Text) = 0 Then
            MsgBox("El tipo de Plantilla ya exite. Escriba otro Tipo", MsgBoxStyle.Information)
            Return False
            Exit Function
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre de Plantilla", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Return False
            Exit Function
        End If

        If cbEsquema.SelectedValue.ToString = 0 Or cbEsquema.SelectedValue.ToString Is DBNull.Value Then
            MsgBox("Seleccione un Tipo de Plantilla", MsgBoxStyle.Information)
            Return False
            Exit Function
        End If

        If cbTipoComp.SelectedValue.ToString = 0 Or cbTipoComp.SelectedValue.ToString Is DBNull.Value Then
            MsgBox("Seleccione un Tipo de Comprobante", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        If Not cbTipoProv.SelectedValue Is Nothing Then

            If cbTipoProv.SelectedText.ToString Is DBNull.Value Or cbTipoProv.SelectedValue.ToString = 0 Then
                MsgBox("Seleccione un Esquema de Plantilla", MsgBoxStyle.Information)
                Return False
                Exit Function
            End If

        Else
            MsgBox("Seleccione un Esquema de Plantilla", MsgBoxStyle.Information)
            Return False
            Exit Function
        End If

        ' En Dependencia del Tipo de Plantilla se continua la validacion
        ' mtto valor
        If cbEsquema.SelectedValue.ToString = 7 And cbTipoProv.SelectedValue.ToString = 1 Then
            If txtIngresoMtto.Text = "" Then
                MsgBox("Seleccione una Cuenta para el Ingreso por Mantenimiento de Valor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtEgresoMtto.Text = "" Then
                MsgBox("Seleccione una Cuenta para el Egreso por Mantenimiento de Valor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 1 Then
            'If txtProvCuenta.Text = "" Or txtProvNombre.Text = "" Then
            '    MsgBox("Seleccione una Cuenta para el Proveedor", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If txtBancoCuenta.Text = "" Or txtBancoNombre.Text = "" Then
            '    MsgBox("Seleccione una Cuenta para el Banco", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            If txtIRCuenta.Text = "" Or txtIRNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtIVACuenta.Text = "" Or txtIVANombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IVA", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If CbProvC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el Proveedor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If CbProvVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el Proveedor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbTipoProv.SelectedValue = 0 Then
                MsgBox("Seleccione un Tipo de Proveedor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbBanC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el Banco", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbBancVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el Banco", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbIVAC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IVA", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If CbIVAVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IVA", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If CbIRC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If CbIRVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
        End If

        ' INSTALACION
        If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 2 Then
            If txtDepCuenta.Text = "" Or txtDept.Text = "" Then
                MsgBox("Seleccione una Cuenta para el Deposito en Garantia", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbDeptC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el Deposito en Garantia", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbDeptVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el Deposito en Garantia", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbDeptC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el Banco", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbBancosVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el Banco", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        ' RECONEXION
        If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 3 Then
            If txtRecoCuenta.Text = "" Or txtReco.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A ", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbRecoC.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el I.V.A", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbRecoVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el I.V.A", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbProvReco.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el Proveedor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbProvVarReco.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el Proveedor", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbBancoReco.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el Banco", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbBancoVarReco.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el Banco", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
        End If

        ' DEPOSITOS DE PROVEEDORES
        If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 4 Then
            If txtCajaCuenta.Text = "" Or txtCaja.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbCajaConcep.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbCajaVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'If Me.txtMoneda1Cuenta.Text = "" Or Me.txtMoneda1Nombre.Text = "" Then
            '    MsgBox("Seleccione una Cuenta para Moneda Nacional", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.cbMoneda1Concepto.SelectedValue = 0 Then
            '    MsgBox("Seleccione un Concepto para Moneda Nacional", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.cbMoneda1Variable.SelectedValue = 0 Then
            '    MsgBox("Seleccione una Variable para Moneda Nacional", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.txtMoneda2Cuenta.Text = "" Or Me.txtMoneda2Nombre.Text = "" Then
            '    MsgBox("Seleccione una Cuenta para Moneda Extranjera", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.cbMoneda2Concepto.SelectedValue = 0 Then
            '    MsgBox("Seleccione un Concepto para Moneda Extranjera", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.cbMoneda2Variable.SelectedValue = 0 Then
            '    MsgBox("Seleccione una Variable para Moneda Extranjera", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If
        End If

        ' NOTA DE DEBITO
        If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 6 Then
            If txtCajaCuenta.Text = "" Or txtCaja.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbCajaConcep.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbCajaVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 7 Then
            If tCust.Rows.Count = 0 Then
                MsgBox("Debe ingresar una cuenta a la Plantilla", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            For i = 0 To tCust.Rows.Count - 1
                'CODIGO
                If tCust.Rows(i)("Cuenta").ToString = "" Or tCust.Rows(i)("Cuenta") Is DBNull.Value Or tCust.Rows(i)("Cuenta").ToString = "" Or tCust.Rows(i)("Cuenta") Is DBNull.Value Then
                    MsgBox("Presione F3 para seleccionar una Cuenta del Catalogo", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If

                ' Etiqueta
                If tCust.Rows(i)("Uso").ToString = "" Or tCust.Rows(i)("Uso") Is DBNull.Value Or tCust.Rows(i)("Uso").ToString = "" Or tCust.Rows(i)("Uso") Is DBNull.Value Then
                    MsgBox("Escriba una etiqueta para la cuenta.", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If

                ' DEBITO  / CREDITO
                If tCust.Rows(i)("DC").ToString = "" Or tCust.Rows(i)("DC") Is DBNull.Value Or tCust.Rows(i)("DC").ToString = "" Or tCust.Rows(i)("DC") Is DBNull.Value Then
                    MsgBox("Seleccione la acción a aplicar a la cuenta: Crédito / Dédito", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                Else
                    ' Una operacion de C / D

                    ' ACT 

                    If tCust.Rows(i)("DC").ToString = "Débito" Then
                        Debito = Debito + 1
                    End If


                    If tCust.Rows(i)("DC").ToString = "Crédito" Then
                        Credito = Credito + 1
                    End If
                End If
            Next

            If Debito = 0 And tCust.Rows.Count > 0 Then
                MsgBox("Debe haber al menos una operación de Débito", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Credito = 0 And tCust.Rows.Count > 0 Then
                MsgBox("Debe haber al menos una operación de Crédito", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
        End If

        ' IVA 
        If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 1 Then
            If txtIVASoport.Text = "" Or txtIVASoportNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IVA Soportado", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtIVAReper.Text = "" Or txtIVAReperNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IVA Repercutido", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtCajaIVA.Text = "" Or txtCajaIVANombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
        End If

        ' I.R.
        If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 2 Then
            If txtIRVent.Text = "" Or txtIRVentNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.R. sobre Ventas", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtIRPag.Text = "" Or txtIRPagNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.R. pagado por adelantado por bienes", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtIRPagServ.Text = "" Or txtIRPagServNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.R. pagado por adelantado por Servicios", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtCajaIR.Text = "" Or txtCajaIRNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja del I.R.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        ' VENTAS DE CONTADO
        If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 1 Then

            'Caja
            If txtCajaCuentaContado.Text = "" Or txtCajaNombreContado.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbCajaConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbCajaVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'Ingresos
            If txtIngrCuenta.Text = "" Or txtIngrNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para los Ingresos", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbIngrConceptos.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para los Ingresos", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbIngrVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para los Ingresos", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'IVA
            If txtIVACuentaIngr.Text = "" Or txtIVAIngr.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbConceptoIVAIngr.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If cbVarIVAIngr.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'IR
            If Me.txtIRContadoCodigo.Text = "" Or Me.txtIRContadoNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRContadoConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRContadoVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


            'IR SOBRE VENTAS ALCALDIA
            If Me.txtIRAlcNombre.Text = "" Or Me.txtIRAlcNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR sobre Ventas", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRAlcConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IR sobre Ventas", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRAlcVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IR sobre Ventas", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        ' VENTAS DE CREDITO
        If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 2 Then
            If txtCuentaCred.Text = "" Or txtNombreCred.Text = "" Then
                MsgBox("Seleccione una Cuenta para los Ingresos", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If txtIVACred.Text = "" Or txtIVACredNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
        End If

        ' DEPOSITOS BANCARIOS
        If cbEsquema.SelectedValue.ToString = 5 And cbTipoProv.SelectedValue.ToString = 1 Then
            If txtCajaCuenta.Text = "" Or txtCaja.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
        End If

        '''' ABONO
        '''If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 1 Then
        '''    If txtCajaCuenta.Text = "" Or txtCaja.Text = "" Then
        '''        MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
        '''        Return False
        '''        Exit Function
        '''    End If
        '''End If

        'ABONO DE CLIENTE - Recibo de Caja
        If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 3 Then
            'Caja
            If Me.txtCajaCodigo.Text = "" Or Me.txtCajaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbCajaConcepto1.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbCajaVariable1.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para la Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'IR
            If Me.txtReciboIRCuenta.Text = "" Or Me.txtReciboIRNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbReciboIRConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbReciboIRVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


            '  IVA
            If Me.txtReciboIvaCuenta.Text = "" Or Me.txtReciboIvaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IVA", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbReciboIvaConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IVA", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'If Me.cbReciboIvaVariable.SelectedValue = 0 Then
            '    MsgBox("Seleccione una Variable para el IVA", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            ''Banco
            'If Me.txtBancoCodigo.Text = "" Or Me.txtBancoNombre.Text = "" Then
            '    MsgBox("Seleccione una Cuenta para el Banco", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.cbBancoConcepto.SelectedValue = 0 Then
            '    MsgBox("Seleccione un Concepto para el Banco", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

            'If Me.cbBancoVariable.SelectedValue = 0 Then
            '    MsgBox("Seleccione una Variable para el Banco", MsgBoxStyle.Critical)
            '    Return False
            '    Exit Function
            'End If

        End If

        ' NOTA DE CREDITO
        If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 4 Then
            'IVA
            If Me.txtNCIvaCodigo.Text = "" Or Me.txtNCIvaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'CAJA
            If Me.txtNCCajaCodigo.Text = "" Or Me.txtNCCajaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        ' COMRPAS DE CONTADO
        If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 1 Then

            'IR
            If Me.txtIRCCCodigo.Text = "" Or Me.txtIRCCNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRCCConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRCCVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IR", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'IVA
            If Me.txtIvaCCCodigo.Text = "" Or Me.txtIvaCCNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIvaCCConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIvaCCVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'BANCO
            If Me.txtccCuenta.Text = "" Or Me.txtccNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbccConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbccVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


            If Me.cbIRCompContConcep.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el IR de la Alcaldia.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRCompContVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el IR de la Alcaldia.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


        End If

        ' COMRPAS DE CREDITO
        If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 2 Then
            'IVA
            If Me.txtIvaCCredCodigo.Text = "" Or Me.txtIvaCCredNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIvaCCredConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIvaCCredVariable.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


            If Me.cbIRAlcCompCredConcepto.SelectedValue = 0 Then
                MsgBox("Seleccione un Concepto para el I.R. de la Alcaldia", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.cbIRAlcCompCredVar.SelectedValue = 0 Then
                MsgBox("Seleccione una Variable para el I.R. de la Alcaldia", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


        End If


        ' NOTA DE DEBITO
        If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 3 Then
            'IVA
            If Me.txtNDIvaCodigo.Text = "" Or Me.txtNDIvaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el I.V.A.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            'CAJA
            If Me.txtNDCajaCodigo.Text = "" Or Me.txtNDCajaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para Caja", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If

        ' IMPUESTOS RETENCIONES, IVA
        If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 3 Then
            'IR
            If Me.txtIRAnticipoCodigo.Text = "" Or Me.txtIRAnticipoNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR Anticipo.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtIRxPCodigo.Text = "" Or Me.txtIRxPNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR por Pagar.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtIRSPCodigo.Text = "" Or Me.txtIRSPNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR de Servicios Profecionales.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtIRSRCodigo.Text = "" Or Me.txtIRSRNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR Sobre Residentes.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtIRSalarioCodigo.Text = "" Or Me.txtIRSalarioNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IR Sobre Salario.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtIva1Codigo.Text = "" Or Me.txtIva1Nombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IVA Por Pagar.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtIva2Codigo.Text = "" Or Me.txtIva2Nombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el IVA Sobre Compras.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtCajaImpCodigo.Text = "" Or Me.txtCajaImpNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para Caja General.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

        End If


        ' IMPUESTOS ALCALDIA
        If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 4 Then
            'IR
            If Me.txtAlcaldiaCodigo.Text = "" Or Me.txtAlcaldiaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para el Impuesto Alcaldia.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If

            If Me.txtAlcaldiaCajaCodigo.Text = "" Or Me.txtAlcaldiaCajaNombre.Text = "" Then
                MsgBox("Seleccione una Cuenta para Caja General.", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If


        End If

        Return True

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObtieneDatoProv()
    End Sub

    Private Sub ObtieneDatoProv()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            'txtProvCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            'txtProvNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            'txtProvCuenta.Text = txtProvCuenta.Text
            'txtProvNombre.Text = txtProvNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoBanco()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            'txtBancoCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            'txtBancoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            'txtBancoCuenta.Text = txtBancoCuenta.Text
            'txtBancoNombre.Text = txtBancoNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoIVA()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            txtIVACuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIVANombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIVACuenta.Text = txtIVACuenta.Text
            txtIVANombre.Text = txtIVANombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoIR()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()
        If F.lblSalir.Text = 1 Then
            txtIRCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIRNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIRCuenta.Text = txtIRCuenta.Text
            txtIRNombre.Text = txtIRNombre.Text
        End If
    End Sub

    Private Sub cbEsquema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEsquema.SelectedIndexChanged
        If IsNumeric(cbEsquema.SelectedValue) Then
            cbTipoProv.DataSource = Plantilla.GetListEsquemaProv(cbEsquema.SelectedValue).Tables("Tablas")
            cbTipoProv.ValueMember = "Esq_Id"
            cbTipoProv.DisplayMember = "Esq_Nombre"
        End If
    End Sub

    Private Sub gbPagoProveedores_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbPagoProveedores.Enter
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ObtieneDatoIR()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ObtieneDatoIVA()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ObtieneDatoBanco()
    End Sub

    Private Sub cbTipoProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoProv.SelectedIndexChanged
        If IsNumeric(cbTipoProv.SelectedValue) Then
            If Plantilla.ValidaPlantillaEsquema(cbTipoProv.SelectedValue.ToString, cbEsquema.SelectedValue.ToString) = False Then
                MsgBox("No se puede crear una nueva plantilla porque ya existe de ese Tipo y Esquema", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If cbEsquema.SelectedValue.ToString = 10 And cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = True
                gbProveedoresServicios.Visible = False

                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbMttoValor.Visible = False
                Me.gbCCBanco.Visible = False


                Me.cbProvP.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbProvP.ValueMember = "Codigo"
                cbProvP.DisplayMember = "Nombre"

                cbProvPVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbProvPVar.ValueMember = "Var_Id"
                cbProvPVar.DisplayMember = "Var_Nombre"

                Me.cbBancoP.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbBancoP.ValueMember = "Codigo"
                cbBancoP.DisplayMember = "Nombre"

                Me.cbBancoPVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbBancoPVar.ValueMember = "Var_Id"
                cbBancoPVar.DisplayMember = "Var_Nombre"

                Me.cbIRP.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIRP.ValueMember = "Codigo"
                cbIRP.DisplayMember = "Nombre"

                Me.cbIRPvar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbIRPvar.ValueMember = "Var_Id"
                cbIRPvar.DisplayMember = "Var_Nombre"


            End If





            If cbEsquema.SelectedValue.ToString = 9 And cbTipoProv.SelectedValue.ToString = 1 Then


                gbProveedorServiciosPagar.Visible = False


                gbProveedoresServicios.Visible = True

                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbMttoValor.Visible = False
                Me.gbCCBanco.Visible = False


                CBGASTOS.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                CBGASTOS.ValueMember = "Codigo"
                CBGASTOS.DisplayMember = "Nombre"

                CBGASTOSVAR.DataSource = VariablesDB.GetList().Tables("Variables")
                CBGASTOSVAR.ValueMember = "Var_Id"
                CBGASTOSVAR.DisplayMember = "Var_Nombre"

                CBIRXPAGAR.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                CBIRXPAGAR.ValueMember = "Codigo"
                CBIRXPAGAR.DisplayMember = "Nombre"

                Me.CBIRXPAGARVAR.DataSource = VariablesDB.GetList().Tables("Variables")
                CBIRXPAGARVAR.ValueMember = "Var_Id"
                CBIRXPAGARVAR.DisplayMember = "Var_Nombre"

                CBPROVEEDOR.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                CBPROVEEDOR.ValueMember = "Codigo"
                CBPROVEEDOR.DisplayMember = "Nombre"

                Me.CBPROVEEDORVAR.DataSource = VariablesDB.GetList().Tables("Variables")
                CBPROVEEDORVAR.ValueMember = "Var_Id"
                CBPROVEEDORVAR.DisplayMember = "Var_Nombre"

                Me.CBIVAPORCOBRAR.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                CBIVAPORCOBRAR.ValueMember = "Codigo"
                CBIVAPORCOBRAR.DisplayMember = "Nombre"

                Me.CBIVAPORCOBRARVAR.DataSource = VariablesDB.GetList().Tables("Variables")
                CBIVAPORCOBRARVAR.ValueMember = "Var_Id"
                CBIVAPORCOBRARVAR.DisplayMember = "Var_Nombre"


                Me.cbIRxPagarC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIRxPagarC.ValueMember = "Codigo"
                Me.cbIRxPagarC.DisplayMember = "Nombre"

                Me.cbIRxPagarV.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIRxPagarV.ValueMember = "Var_Id"
                Me.cbIRxPagarV.DisplayMember = "Var_Nombre"


                Me.cbIRxPagAlcC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIRxPagAlcC.ValueMember = "Codigo"
                Me.cbIRxPagAlcC.DisplayMember = "Nombre"

                Me.cbIRxPagAlcVar.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIRxPagAlcVar.ValueMember = "Var_Id"
                Me.cbIRxPagAlcVar.DisplayMember = "Var_Nombre"




            End If



            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = True
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbMttoValor.Visible = False
                Me.gbCCBanco.Visible = False

                CbProvC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                CbProvC.ValueMember = "Codigo"
                CbProvC.DisplayMember = "Nombre"

                cbBanC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbBanC.ValueMember = "Codigo"
                cbBanC.DisplayMember = "Nombre"

                CbIRC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                CbIRC.ValueMember = "Codigo"
                CbIRC.DisplayMember = "Nombre"

                cbIVAC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIVAC.ValueMember = "Codigo"
                cbIVAC.DisplayMember = "Nombre"

                CbProvVar.DataSource = VariablesDB.GetList().Tables("Variables")
                CbProvVar.ValueMember = "Var_Id"
                CbProvVar.DisplayMember = "Var_Nombre"

                cbBancVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbBancVar.ValueMember = "Var_Id"
                cbBancVar.DisplayMember = "Var_Nombre"

                CbIVAVar.DataSource = VariablesDB.GetList().Tables("Variables")
                CbIVAVar.ValueMember = "Var_Id"
                CbIVAVar.DisplayMember = "Var_Nombre"

                CbIRVar.DataSource = VariablesDB.GetList().Tables("Variables")
                CbIRVar.ValueMember = "Var_Id"
                CbIRVar.DisplayMember = "Var_Nombre"


            End If


            'Proveedores de Productos
            If cbEsquema.SelectedValue.ToString = 8 And cbTipoProv.SelectedValue.ToString = 10 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                Me.gbPagoProductos.Visible = True
                Me.gbMttoValor.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbIVAProdC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIVAProdC.ValueMember = "Codigo"
                cbIVAProdC.DisplayMember = "Nombre"

                cbIVAProdVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbIVAProdVar.ValueMember = "Var_Id"
                cbIVAProdVar.DisplayMember = "Var_Nombre"

                cbProvProdC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbProvProdC.ValueMember = "Codigo"
                cbProvProdC.DisplayMember = "Nombre"

                cbProvProdVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbProvProdVar.ValueMember = "Var_Id"
                cbProvProdVar.DisplayMember = "Var_Nombre"

                cBancosProdC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cBancosProdC.ValueMember = "Codigo"
                cBancosProdC.DisplayMember = "Nombre"

                cBancosProdVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cBancosProdVar.ValueMember = "Var_Id"
                cBancosProdVar.DisplayMember = "Var_Nombre"

            End If



            'Mantenimiento de Valor
            If cbEsquema.SelectedValue.ToString = 7 And cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = False

                Me.gbMttoValor.Visible = True
                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = True
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

            End If
            ' INSTALACION
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 2 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                gbInstalacion.Visible = True
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbDeptC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbDeptC.ValueMember = "Codigo"
                cbDeptC.DisplayMember = "Nombre"

                cbDeptVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbDeptVar.ValueMember = "Var_Id"
                cbDeptVar.DisplayMember = "Var_Nombre"

                cbBancos.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbBancos.ValueMember = "Codigo"
                cbBancos.DisplayMember = "Nombre"

                cbBancosVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbBancosVar.ValueMember = "Var_Id"
                cbBancosVar.DisplayMember = "Var_Nombre"
            End If

            ' RECONEXION
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 3 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                gbReconexion.Visible = True
                gbInstalacion.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbBlank.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbRecoC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbRecoC.ValueMember = "Codigo"
                cbRecoC.DisplayMember = "Nombre"

                cbRecoVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbRecoVar.ValueMember = "Var_Id"
                cbRecoVar.DisplayMember = "Var_Nombre"

                cbProvReco.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbProvReco.ValueMember = "Codigo"
                cbProvReco.DisplayMember = "Nombre"

                cbProvVarReco.DataSource = VariablesDB.GetList().Tables("Variables")
                cbProvVarReco.ValueMember = "Var_Id"
                cbProvVarReco.DisplayMember = "Var_Nombre"

                cbBancoReco.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbBancoReco.ValueMember = "Codigo"
                cbBancoReco.DisplayMember = "Nombre"

                cbBancoVarReco.DataSource = VariablesDB.GetList().Tables("Variables")
                cbBancoVarReco.ValueMember = "Var_Id"
                cbBancoVarReco.DisplayMember = "Var_Nombre"
            End If

            ' DEPOSITO
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 4 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = True
                cbCajaVar.Visible = True
                cbCajaConcep.Visible = True
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbCajaConcep.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbCajaConcep.ValueMember = "Codigo"
                cbCajaConcep.DisplayMember = "Nombre"

                cbCajaVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbCajaVar.ValueMember = "Var_Id"
                cbCajaVar.DisplayMember = "Var_Nombre"
            End If

            ' ABONO
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 5 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = True
                cbCajaVar.Visible = True
                cbCajaConcep.Visible = True
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbCajaConcep.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbCajaConcep.ValueMember = "Codigo"
                cbCajaConcep.DisplayMember = "Nombre"

                cbCajaVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbCajaVar.ValueMember = "Var_Id"
                cbCajaVar.DisplayMember = "Var_Nombre"
            End If

            ' NOTA DE DEBITO
            If cbEsquema.SelectedValue.ToString = 1 And cbTipoProv.SelectedValue.ToString = 6 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = True
                cbCajaVar.Visible = True
                cbCajaConcep.Visible = True
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbCajaConcep.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbCajaConcep.ValueMember = "Codigo"
                cbCajaConcep.DisplayMember = "Nombre"

                cbCajaVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbCajaVar.ValueMember = "Var_Id"
                cbCajaVar.DisplayMember = "Var_Nombre"
            End If

            ' I.V.A
            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = True
                gbxIVA.BringToFront()
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False
            End If

            ' I.R.
            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 2 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = True
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False
            End If

            ' VENTAS DE CONTADO
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = True
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                cbCajaConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbCajaConcepto.ValueMember = "Codigo"
                cbCajaConcepto.DisplayMember = "Nombre"

                cbCajaVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                cbCajaVariable.ValueMember = "Var_Id"
                cbCajaVariable.DisplayMember = "Var_Nombre"

                cbdevolucionconcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbdevolucionconcepto.ValueMember = "Codigo"
                cbdevolucionconcepto.DisplayMember = "Nombre"

                cbdevolucionvariable.DataSource = VariablesDB.GetList().Tables("Variables")
                cbdevolucionvariable.ValueMember = "Var_Id"
                cbdevolucionvariable.DisplayMember = "Var_Nombre"

                cbIngrConceptos.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIngrConceptos.ValueMember = "Codigo"
                cbIngrConceptos.DisplayMember = "Nombre"

                cbIngrVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                cbIngrVariable.ValueMember = "Var_Id"
                cbIngrVariable.DisplayMember = "Var_Nombre"

                cbConceptoIVAIngr.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbConceptoIVAIngr.ValueMember = "Codigo"
                cbConceptoIVAIngr.DisplayMember = "Nombre"

                cbVarIVAIngr.DataSource = VariablesDB.GetList().Tables("Variables")
                cbVarIVAIngr.ValueMember = "Var_Id"
                cbVarIVAIngr.DisplayMember = "Var_Nombre"

                Me.cbIRContadoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIRContadoConcepto.ValueMember = "Codigo"
                Me.cbIRContadoConcepto.DisplayMember = "Nombre"

                Me.cbIRContadoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIRContadoVariable.ValueMember = "Var_Id"
                Me.cbIRContadoVariable.DisplayMember = "Var_Nombre"

                cbConceptoCostoVentaIngr.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbConceptoCostoVentaIngr.ValueMember = "Codigo"
                cbConceptoCostoVentaIngr.DisplayMember = "Nombre"

                cbVarCostoVentaIngr.DataSource = VariablesDB.GetList().Tables("Variables")
                cbVarCostoVentaIngr.ValueMember = "Var_Id"
                cbVarCostoVentaIngr.DisplayMember = "Var_Nombre"

                cbInventarioVentaIngr.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbInventarioVentaIngr.ValueMember = "Codigo"
                cbInventarioVentaIngr.DisplayMember = "Nombre"

                cbVarInventarioIngr.DataSource = VariablesDB.GetList().Tables("Variables")
                cbVarInventarioIngr.ValueMember = "Var_Id"
                cbVarInventarioIngr.DisplayMember = "Var_Nombre"


                cbIngresoCreditoCostoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIngresoCreditoCostoConcepto.ValueMember = "Codigo"
                cbIngresoCreditoCostoConcepto.DisplayMember = "Nombre"

                cbIngresoCreditoCostoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                cbIngresoCreditoCostoVariable.ValueMember = "Var_Id"
                cbIngresoCreditoCostoVariable.DisplayMember = "Var_Nombre"


                cbInventarioConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbInventarioConcepto.ValueMember = "Codigo"
                cbInventarioConcepto.DisplayMember = "Nombre"

                cbInventarioVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                cbInventarioVariable.ValueMember = "Var_Id"
                cbInventarioVariable.DisplayMember = "Var_Nombre"



                Me.cbIRAlcConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIRAlcConcepto.ValueMember = "Codigo"
                cbIRAlcConcepto.DisplayMember = "Nombre"

                Me.cbIRAlcVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                cbIRAlcVariable.ValueMember = "Var_Id"
                cbIRAlcVariable.DisplayMember = "Var_Nombre"


            End If

            ' VENTAS DE CREDITO
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 2 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = True
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                'Me.cbClienteConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbClienteConcepto.ValueMember = "Codigo"
                'Me.cbClienteConcepto.DisplayMember = "Nombre"

                'Me.cbClienteVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbClienteVariable.ValueMember = "Var_Id"
                'Me.cbClienteVariable.DisplayMember = "Var_Nombre"

                Me.cbIngresoCreditoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIngresoCreditoConcepto.ValueMember = "Codigo"
                Me.cbIngresoCreditoConcepto.DisplayMember = "Nombre"

                Me.cbIngresoCreditoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIngresoCreditoVariable.ValueMember = "Var_Id"
                Me.cbIngresoCreditoVariable.DisplayMember = "Var_Nombre"

                Me.cbIvaCreditoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIvaCreditoConcepto.ValueMember = "Codigo"
                Me.cbIvaCreditoConcepto.DisplayMember = "Nombre"

                Me.cbIvaCreditoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIvaCreditoVariable.ValueMember = "Var_Id"
                Me.cbIvaCreditoVariable.DisplayMember = "Var_Nombre"

                Me.cbIngresoCreditoCostoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIngresoCreditoCostoConcepto.ValueMember = "Codigo"
                Me.cbIngresoCreditoCostoConcepto.DisplayMember = "Nombre"

                Me.cbIngresoCreditoCostoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIngresoCreditoCostoVariable.ValueMember = "Var_Id"
                Me.cbIngresoCreditoCostoVariable.DisplayMember = "Var_Nombre"

                Me.cbIngresoCreditoCostoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIngresoCreditoCostoConcepto.ValueMember = "Codigo"
                Me.cbIngresoCreditoCostoConcepto.DisplayMember = "Nombre"

                Me.cbInventarioConcepto.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbInventarioConcepto.ValueMember = "Var_Id"
                Me.cbInventarioConcepto.DisplayMember = "Var_Nombre"

                Me.cbInventarioVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbInventarioVariable.ValueMember = "Var_Id"
                Me.cbInventarioVariable.DisplayMember = "Var_Nombre"

                'Me.cbIrCreditoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbIrCreditoConcepto.ValueMember = "Codigo"
                'Me.cbIrCreditoConcepto.DisplayMember = "Nombre"

                'Me.cbIRCreditoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbIRCreditoVariable.ValueMember = "Var_Id"
                'Me.cbIRCreditoVariable.DisplayMember = "Var_Nombre"
            End If

            ' NOTAS DE CREDITO
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 4 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = True
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                'Me.cbClienteConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbClienteConcepto.ValueMember = "Codigo"
                'Me.cbClienteConcepto.DisplayMember = "Nombre"

                'Me.cbClienteVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbClienteVariable.ValueMember = "Var_Id"
                'Me.cbClienteVariable.DisplayMember = "Var_Nombre"

                'Me.cbIngresoCreditoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbIngresoCreditoConcepto.ValueMember = "Codigo"
                'Me.cbIngresoCreditoConcepto.DisplayMember = "Nombre"

                'Me.cbIngresoCreditoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbIngresoCreditoVariable.ValueMember = "Var_Id"
                'Me.cbIngresoCreditoVariable.DisplayMember = "Var_Nombre"

                'Me.cbIvaCreditoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbIvaCreditoConcepto.ValueMember = "Codigo"
                'Me.cbIvaCreditoConcepto.DisplayMember = "Nombre"

                'Me.cbIvaCreditoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbIvaCreditoVariable.ValueMember = "Var_Id"
                'Me.cbIvaCreditoVariable.DisplayMember = "Var_Nombre"

                'Me.cbIrCreditoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbIrCreditoConcepto.ValueMember = "Codigo"
                'Me.cbIrCreditoConcepto.DisplayMember = "Nombre"

                'Me.cbIRCreditoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbIRCreditoVariable.ValueMember = "Var_Id"
                'Me.cbIRCreditoVariable.DisplayMember = "Var_Nombre"
            End If

            If cbEsquema.SelectedValue.ToString = 5 And cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                gbReconexion.Visible = False
                gbInstalacion.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbBlank.Visible = False
                gbCaja.Visible = True
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False
                'Me.gbDepositoBancario.Visible = True
            End If

            'ABONO DE CLIENTE - Recibo de Caja
            If cbEsquema.SelectedValue.ToString = 4 And cbTipoProv.SelectedValue.ToString = 3 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = True
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = False

                Me.cbCajaConcepto1.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbCajaConcepto1.ValueMember = "Codigo"
                Me.cbCajaConcepto1.DisplayMember = "Nombre"

                Me.cbCajaVariable1.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbCajaVariable1.ValueMember = "Var_Id"
                Me.cbCajaVariable1.DisplayMember = "Var_Nombre"

                Me.cbReciboIRConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbReciboIRConcepto.ValueMember = "Codigo"
                Me.cbReciboIRConcepto.DisplayMember = "Nombre"

                Me.cbReciboIRVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbReciboIRVariable.ValueMember = "Var_Id"
                Me.cbReciboIRVariable.DisplayMember = "Var_Nombre"

                Me.cbReciboIvaConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbReciboIvaConcepto.ValueMember = "Codigo"
                Me.cbReciboIvaConcepto.DisplayMember = "Nombre"

                Me.cbReciboIvaVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbReciboIvaVariable.ValueMember = "Var_Id"
                Me.cbReciboIvaVariable.DisplayMember = "Var_Nombre"

                'Me.cbBancoConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'Me.cbBancoConcepto.ValueMember = "Codigo"
                'Me.cbBancoConcepto.DisplayMember = "Nombre"

                'Me.cbBancoVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                'Me.cbBancoVariable.ValueMember = "Var_Id"
                'Me.cbBancoVariable.DisplayMember = "Var_Nombre"
            End If


            ' COMPRAS DE CONTADO
            If Me.cbEsquema.SelectedValue.ToString = 6 And Me.cbTipoProv.SelectedValue.ToString = 1 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = True
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False
                Me.gbCCBanco.Visible = True


                Me.cbIvaCCConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIvaCCConcepto.ValueMember = "Codigo"
                Me.cbIvaCCConcepto.DisplayMember = "Nombre"

                Me.cbIvaCCVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIvaCCVariable.ValueMember = "Var_Id"
                Me.cbIvaCCVariable.DisplayMember = "Var_Nombre"

                Me.cbIRCCConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIRCCConcepto.ValueMember = "Codigo"
                Me.cbIRCCConcepto.DisplayMember = "Nombre"

                Me.cbIRCCVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIRCCVariable.ValueMember = "Var_Id"
                Me.cbIRCCVariable.DisplayMember = "Var_Nombre"

                Me.cbccConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbccConcepto.ValueMember = "Codigo"
                Me.cbccConcepto.DisplayMember = "Nombre"

                Me.cbccVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbccVariable.ValueMember = "Var_Id"
                Me.cbccVariable.DisplayMember = "Var_Nombre"


                Me.cbIRCompContConcep.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIRCompContConcep.ValueMember = "Codigo"
                Me.cbIRCompContConcep.DisplayMember = "Nombre"

                Me.cbIRCompContVar.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIRCompContVar.ValueMember = "Var_Id"
                Me.cbIRCompContVar.DisplayMember = "Var_Nombre"
            End If

            ' COMPRAS DE CREDITO
            If Me.cbEsquema.SelectedValue.ToString = 6 And Me.cbTipoProv.SelectedValue.ToString = 2 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = True
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False

                Me.cbIvaCCredConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                Me.cbIvaCCredConcepto.ValueMember = "Codigo"
                Me.cbIvaCCredConcepto.DisplayMember = "Nombre"

                Me.cbIvaCCredVariable.DataSource = VariablesDB.GetList().Tables("Variables")
                Me.cbIvaCCredVariable.ValueMember = "Var_Id"
                Me.cbIvaCCredVariable.DisplayMember = "Var_Nombre"


                cbCompraCredConcep.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbCompraCredConcep.ValueMember = "Codigo"
                cbCompraCredConcep.DisplayMember = "Nombre"


                Me.cbCompraCredVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbCompraCredVar.ValueMember = "Var_Id"
                cbCompraCredVar.DisplayMember = "Var_Nombre"


                Me.cbIRAlcCompCredConcepto.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                cbIRAlcCompCredConcepto.ValueMember = "Codigo"
                cbIRAlcCompCredConcepto.DisplayMember = "Nombre"


                Me.cbIRAlcCompCredVar.DataSource = VariablesDB.GetList().Tables("Variables")
                cbIRAlcCompCredVar.ValueMember = "Var_Id"
                cbIRAlcCompCredVar.DisplayMember = "Var_Nombre"

            End If

            '''
            ' NOTAS DE DEBITO
            If cbEsquema.SelectedValue.ToString = 6 And cbTipoProv.SelectedValue.ToString = 3 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                cbCajaVar.Visible = False
                cbCajaConcep.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = True
                Me.gbAlcaldia.Visible = False
            End If
            '''

            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 3 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = True
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = False

                'CbProvC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'CbProvC.ValueMember = "Codigo"
                'CbProvC.DisplayMember = "Nombre"

                'cbBanC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'cbBanC.ValueMember = "Codigo"
                'cbBanC.DisplayMember = "Nombre"

                'CbIRC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'CbIRC.ValueMember = "Codigo"
                'CbIRC.DisplayMember = "Nombre"

                'cbIVAC.DataSource = ConceptoDB.GetListar().Tables("Conceptos")
                'cbIVAC.ValueMember = "Codigo"
                'cbIVAC.DisplayMember = "Nombre"

                'CbProvVar.DataSource = VariablesDB.GetList().Tables("Variables")
                'CbProvVar.ValueMember = "Var_Id"
                'CbProvVar.DisplayMember = "Var_Nombre"

                'cbBancVar.DataSource = VariablesDB.GetList().Tables("Variables")
                'cbBancVar.ValueMember = "Var_Id"
                'cbBancVar.DisplayMember = "Var_Nombre"

                'CbIVAVar.DataSource = VariablesDB.GetList().Tables("Variables")
                'CbIVAVar.ValueMember = "Var_Id"
                'CbIVAVar.DisplayMember = "Var_Nombre"

                'CbIRVar.DataSource = VariablesDB.GetList().Tables("Variables")
                'CbIRVar.ValueMember = "Var_Id"
                'CbIRVar.DisplayMember = "Var_Nombre"


            End If

            '  ABONO DE CLIENTES

            If cbEsquema.SelectedValue.ToString = 3 And cbTipoProv.SelectedValue.ToString = 4 Then

                gbProveedorServiciosPagar.Visible = False

                gbProveedoresServicios.Visible = False
                dgFacturacionCliente.Visible = False
                gbPagoProveedores.Visible = False
                gbInstalacion.Visible = False
                gbBlank.Visible = False
                gbReconexion.Visible = False
                gbCaja.Visible = False
                gbxContado.Visible = False
                gbxCredito.Visible = False
                gbxIVA.Visible = False
                gbxIR.Visible = False
                Me.gbReciboCaja.Visible = False
                Me.gbDepositoBancario.Visible = False
                Me.gbComprasContado.Visible = False
                Me.gbComprasCredito.Visible = False
                Me.gbImpuestos.Visible = False
                Me.gbNotaCredito.Visible = False
                Me.gbNotaDebito.Visible = False
                Me.gbAlcaldia.Visible = True

            End If

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ObtieneDatoDpGarantia()
    End Sub

    Private Sub ObtieneDatoDpGarantia()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            txtDepCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtDept.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtDepCuenta.Text = txtDepCuenta.Text
            txtDept.Text = txtDept.Text
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ObtieneDatoReconexion()
    End Sub

    Private Sub ObtieneDatoReconexion()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            txtRecoCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtReco.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtRecoCuenta.Text = txtRecoCuenta.Text
            txtReco.Text = txtReco.Text
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ObtieneDatoDepositos()
    End Sub

    Private Sub ObtieneDatoDepositos()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then

            txtCajaCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtCaja.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtCajaCuenta.Text = txtCajaCuenta.Text
            txtCaja.Text = txtCaja.Text
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ObtieneDatoContado()
    End Sub

    Private Sub ObtieneDatoContado()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtCajaCuentaContado.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtCajaNombreContado.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else

            txtCajaCuentaContado.Text = txtCajaCuentaContado.Text
            txtCajaNombreContado.Text = txtCajaNombreContado.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ObtieneDatoIngresos()
    End Sub

    Private Sub ObtieneDatoIngresos()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then

            txtIngrCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIngrNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIngrCuenta.Text = txtIngrCuenta.Text
            txtIngrNombre.Text = txtIngrNombre.Text
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ObtieneDatoIngresosIVA()
    End Sub

    Private Sub ObtieneDatoIngresosIVA()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIVACuentaIngr.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIVAIngr.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIVACuentaIngr.Text = txtIVACuentaIngr.Text
            txtIVAIngr.Text = txtIVAIngr.Text
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ObtieneDatoCredito()
    End Sub

    Private Sub ObtieneDatoCredito()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtCuentaCred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtNombreCred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtCuentaCred.Text = txtCuentaCred.Text
            txtNombreCred.Text = txtNombreCred.Text
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ObtieneDatoCreditoIVA()
    End Sub

    Private Sub ObtieneDatoCreditoIVA()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIVACred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIVACredNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else

            txtIVACred.Text = txtIVACred.Text
            txtIVACredNombre.Text = txtIVACredNombre.Text
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ObtieneDatoIVASoport()
    End Sub

    Private Sub ObtieneDatoIVASoport()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIVASoport.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIVASoportNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIVASoport.Text = txtIVASoport.Text
            txtIVASoportNombre.Text = txtIVASoportNombre.Text
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ObtieneDatoIVARepert()
    End Sub


    Private Sub ObtieneDatoIVARepert()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIVAReper.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIVAReperNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIVAReper.Text = txtIVAReper.Text
            txtIVAReperNombre.Text = txtIVAReperNombre.Text
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ObtieneDatoIRVentas()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIRVent.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIRVentNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIRVent.Text = txtIRVent.Text
            txtIRVentNombre.Text = txtIRVentNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoIRPagado()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIRPag.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIRPagNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIRPag.Text = txtIRPag.Text
            txtIRPagNombre.Text = txtIRPagNombre.Text
        End If
    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        ObtieneDatoIRVentas()
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ObtieneDatoIRPagado()
    End Sub


    Private Sub ObtieneDatoIRPagadoServ()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtIRPagServ.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIRPagServNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIRPagServ.Text = txtIRPagServ.Text
            txtIRPagServNombre.Text = txtIRPagServNombre.Text
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ObtieneDatoIRPagadoServ()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        ObtieneDatoIRCaja()
    End Sub

    Private Sub ObtieneDatoIRCaja()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtCajaIR.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtCajaIRNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtCajaIR.Text = txtCajaIR.Text
            txtCajaIRNombre.Text = txtCajaIRNombre.Text
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        ObtieneDatoIVACaja()
    End Sub

    Private Sub ObtieneDatoIVACaja()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtCajaIVA.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtCajaIVANombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtCajaIVA.Text = txtCajaIVA.Text
            txtCajaIVANombre.Text = txtCajaIVANombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoIngresosIR()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRContadoCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRContadoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRContadoCodigo.Text = Me.txtIRContadoCodigo.Text
            Me.txtIRContadoNombre.Text = Me.txtIRContadoNombre.Text
        End If
    End Sub

    Private Sub cmdIRCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRCatalogo.Click
        ObtieneDatoIngresosIR()
    End Sub

    Private Sub ObtieneDatoCajaRecibo()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtCajaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtCajaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtCajaCodigo.Text = Me.txtCajaCodigo.Text
            Me.txtCajaNombre.Text = Me.txtCajaNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoReciboIR()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtReciboIRCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtReciboIRNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtReciboIRCuenta.Text = Me.txtReciboIRCuenta.Text
            Me.txtReciboIRNombre.Text = Me.txtReciboIRNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoReciboIVA()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtReciboIvaCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtReciboIvaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtReciboIvaCuenta.Text = Me.txtReciboIvaCuenta.Text
            Me.txtReciboIvaNombre.Text = Me.txtReciboIvaNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoDepositos1()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then

            Me.txtMoneda1Cuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtMoneda1Nombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtMoneda1Cuenta.Text = Me.txtMoneda1Cuenta.Text
            Me.txtMoneda1Nombre.Text = Me.txtMoneda1Nombre.Text
        End If
    End Sub

    Private Sub ObtieneDatoDepositos2()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then

            Me.txtMoneda2Cuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtMoneda2Nombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtMoneda2Cuenta.Text = Me.txtMoneda2Cuenta.Text
            Me.txtMoneda2Nombre.Text = Me.txtMoneda2Nombre.Text
        End If
    End Sub

    Private Sub ObtieneDatosIvaCompraContado()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIvaCCCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIvaCCNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIvaCCCodigo.Text = Me.txtIvaCCCodigo.Text
            Me.txtIvaCCNombre.Text = Me.txtIvaCCNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatosIRCompraContado()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIRCCCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRCCNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRCCCodigo.Text = Me.txtIRCCCodigo.Text
            Me.txtIRCCNombre.Text = Me.txtIRCCNombre.Text
        End If
    End Sub

    Private Sub ObtieneDatosIvaCompraCredito()
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIvaCCredCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIvaCCredNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIvaCCredCodigo.Text = Me.txtIvaCCredCodigo.Text
            Me.txtIvaCCredNombre.Text = Me.txtIvaCCredNombre.Text
        End If
    End Sub

    'Private Sub ObtieneDatoBancoRecibo()
    '    Dim F As New frmCuentasBuscar()
    '    F.ShowDialog()

    '    F.lblGrupo.Text = 1

    '    If F.lblSalir.Text = 1 Then
    '        Me.txtBancoCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
    '        Me.txtBancoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
    '    Else
    '        Me.txtBancoCodigo.Text = Me.txtBancoCodigo.Text
    '        Me.txtBancoNombre.Text = Me.txtBancoNombre.Text

    '    End If
    'End Sub

    'Private Sub ObtieneDatoClienteCredito()
    '    Dim F As New frmCuentasBuscar()
    '    F.ShowDialog()

    '    F.lblGrupo.Text = 1

    '    If F.lblSalir.Text = 1 Then

    '        Me.txtClienteCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
    '        Me.txtClienteNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
    '    Else

    '        Me.txtClienteCodigo.Text = Me.txtClienteCodigo.Text
    '        Me.txtClienteNombre.Text = Me.txtClienteNombre.Text

    '    End If
    'End Sub

    'Private Sub ObtieneDatoIRCredito()
    '    Dim F As New frmCuentasBuscar()
    '    F.ShowDialog()

    '    F.lblGrupo.Text = 1

    '    If F.lblSalir.Text = 1 Then

    '        Me.txtIRCreditoCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
    '        Me.txtIRCreditoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
    '    Else

    '        Me.txtIRCreditoCodigo.Text = Me.txtIRCreditoCodigo.Text
    '        Me.txtIRCreditoNombre.Text = Me.txtIRCreditoNombre.Text

    '    End If
    'End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        ObtieneDatoCajaRecibo()
    End Sub

    'Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ObtieneDatoBancoRecibo()
    'End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        ObtieneDatoDepositos1()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        ObtieneDatoDepositos2()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Me.ObtieneDatoReciboIR()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Me.ObtieneDatoReciboIVA()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        ObtieneDatosIvaCompraContado()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        ObtieneDatosIRCompraContado()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        ObtieneDatosIvaCompraCredito()
    End Sub

    Private Sub cmdIRAnticipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRAnticipo.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIRAnticipoCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRAnticipoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRAnticipoCodigo.Text = Me.txtIRAnticipoCodigo.Text
            Me.txtIRAnticipoNombre.Text = Me.txtIRAnticipoNombre.Text
        End If
    End Sub

    Private Sub cmdIRxPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRxPagar.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIRxPCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRxPNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRxPCodigo.Text = Me.txtIRxPCodigo.Text
            Me.txtIRxPNombre.Text = Me.txtIRxPNombre.Text
        End If
    End Sub

    Private Sub cmdIRSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRSP.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIRSPCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRSPNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRSPCodigo.Text = Me.txtIRxPCodigo.Text
            Me.txtIRSPNombre.Text = Me.txtIRSPNombre.Text
        End If
    End Sub

    Private Sub cmdIRResidentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRResidentes.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIRSRCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRSRNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRSRCodigo.Text = Me.txtIRSRCodigo.Text
            Me.txtIRSRNombre.Text = Me.txtIRSRNombre.Text
        End If
    End Sub

    Private Sub cmdIRSalario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRSalario.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIRSalarioCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRSalarioNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIRSalarioCodigo.Text = Me.txtIRSalarioCodigo.Text
            Me.txtIRSalarioNombre.Text = Me.txtIRSalarioNombre.Text
        End If
    End Sub

    Private Sub cmdIva1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIva1.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIva1Codigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIva1Nombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIva1Codigo.Text = Me.txtIva1Codigo.Text
            Me.txtIva1Nombre.Text = Me.txtIva1Nombre.Text
        End If
    End Sub

    Private Sub cmdIva2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIva2.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtIva2Codigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIva2Nombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtIva2Codigo.Text = Me.txtIva2Codigo.Text
            Me.txtIva2Nombre.Text = Me.txtIva2Nombre.Text
        End If
    End Sub

    Private Sub cmdCajaImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCajaImp.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtCajaImpCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtCajaImpNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtCajaImpCodigo.Text = Me.txtCajaImpCodigo.Text
            Me.txtCajaImpNombre.Text = Me.txtCajaImpNombre.Text
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtNCIvaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtNCIvaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtNCIvaCodigo.Text = Me.txtNCIvaCodigo.Text
            Me.txtNCIvaNombre.Text = Me.txtNCIvaNombre.Text
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtNCCajaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtNCCajaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtNCCajaCodigo.Text = Me.txtNCCajaCodigo.Text
            Me.txtNCCajaNombre.Text = Me.txtNCCajaNombre.Text
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtNDIvaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtNDIvaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtNDIvaCodigo.Text = Me.txtNDIvaCodigo.Text
            Me.txtNDIvaNombre.Text = Me.txtNDIvaNombre.Text
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtNDCajaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtNDCajaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtNDCajaCodigo.Text = Me.txtNDCajaCodigo.Text
            Me.txtNDCajaNombre.Text = Me.txtNDCajaNombre.Text
        End If
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtAlcaldiaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtAlcaldiaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtAlcaldiaCodigo.Text = Me.txtAlcaldiaCodigo.Text
            Me.txtAlcaldiaNombre.Text = Me.txtAlcaldiaNombre.Text
        End If
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtAlcaldiaCajaCodigo.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtAlcaldiaCajaNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtAlcaldiaCajaCodigo.Text = Me.txtAlcaldiaCajaCodigo.Text
            Me.txtAlcaldiaCajaNombre.Text = Me.txtAlcaldiaCajaNombre.Text
        End If
    End Sub





    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtCostoVentaCuentaIngr.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtCostoVentaNombreIngr.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtCostoVentaCuentaIngr.Text = Me.txtCostoVentaCuentaIngr.Text
            Me.txtCostoVentaNombreIngr.Text = Me.txtCostoVentaNombreIngr.Text
        End If

    End Sub


    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtInventarioCuentaIngr.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtInventarioNombreIngr.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtInventarioCuentaIngr.Text = Me.txtInventarioCuentaIngr.Text
            Me.txtInventarioNombreIngr.Text = Me.txtInventarioNombreIngr.Text
        End If


    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtCuentaCostoCred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtNombreCostoCred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtCuentaCostoCred.Text = Me.txtCuentaCostoCred.Text
            Me.txtNombreCostoCred.Text = Me.txtNombreCostoCred.Text
        End If


    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        If F.lblSalir.Text = 1 Then
            Me.txtInventarioCred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtNombreInventarioCred.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            Me.txtInventarioCred.Text = Me.txtInventarioCred.Text
            Me.txtNombreInventarioCred.Text = Me.txtNombreInventarioCred.Text
        End If
    End Sub




    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIngresoMtto.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtIngresoMttoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtIngresoMtto.Text = txtIngresoMtto.Text
            txtIngresoMttoNombre.Text = txtIngresoMttoNombre.Text
        End If
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtEgresoMtto.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtEgresoMttoNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtEgresoMtto.Text = txtEgresoMtto.Text
            txtEgresoMttoNombre.Text = txtEgresoMttoNombre.Text
        End If
    End Sub


    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtProdIVACta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtProdIVANombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtProdIVACta.Text = txtProdIVACta.Text
            txtProdIVANombre.Text = txtProdIVANombre.Text
        End If

    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtProdProvCta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtProdProvNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtProdProvCta.Text = txtProdProvCta.Text
            txtProdProvNombre.Text = txtProdProvNombre.Text
        End If
    End Sub


    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            txtProdBancos.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            txtProdBancosNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            txtProdBancos.Text = txtProdBancos.Text
            txtProdBancosNombre.Text = txtProdBancosNombre.Text
        End If
    End Sub



    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            TXTGASTOSCUENTA.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            TXTGASTOSNOMBRE.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            TXTGASTOSCUENTA.Text = txtProdBancos.Text
            TXTGASTOSNOMBRE.Text = txtProdBancosNombre.Text
        End If

    End Sub




    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            TXTPROVEEDORCUENTA.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            TXTPROVEEDORNOMBRE.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            TXTPROVEEDORCUENTA.Text = txtProdBancos.Text
            TXTPROVEEDORNOMBRE.Text = txtProdBancosNombre.Text
        End If

    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            TXTIRXPAGARCUENTA.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            TXTIRXPAGARNOMBRE.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            TXTIRXPAGARCUENTA.Text = txtProdBancos.Text
            TXTIRXPAGARNOMBRE.Text = txtProdBancosNombre.Text
        End If
    End Sub

    Private Sub gbProveedoresServicios_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbProveedoresServicios.Enter


    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            TXTIVAXCOBRAR.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            TXTIVAPORCOBRARNOMBRE.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
            '            ME.CBIVAPORCOBRAR 
        Else
            TXTIVAXCOBRAR.Text = txtProdBancos.Text
            TXTIVAPORCOBRARNOMBRE.Text = txtProdBancosNombre.Text
        End If
    End Sub


    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtProvP.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtProvPNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
            '            ME.CBIVAPORCOBRAR 
        Else
            txtProvP.Text = txtProvP.Text
            txtProvPNombre.Text = txtProvPNombre.Text
        End If

    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtBancoP.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtBancoPNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
            '            ME.CBIVAPORCOBRAR 
        Else
            txtBancoP.Text = txtBancoP.Text
            txtBancoPNombre.Text = txtBancoPNombre.Text
        End If

    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRP.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRPNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
            '            ME.CBIVAPORCOBRAR 
        Else
            txtIRP.Text = txtIRP.Text
            txtIRPNombre.Text = txtIRPNombre.Text
        End If

    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRxPagarC.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRxPagarN.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtIRxPagarC.Text = txtIRxPagarC.Text
            txtIRxPagarN.Text = txtIRxPagarN.Text
        End If

    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click


        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRCompraCredC.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRCompraCredN.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtIRCompraCredC.Text = txtIRCompraCredC.Text
            txtIRCompraCredN.Text = txtIRCompraCredN.Text
        End If

    End Sub

    Private Sub txtIRCompraCredC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIRCompraCredC.TextChanged

    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtccCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtccNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtccCuenta.Text = txtccCuenta.Text
            txtccNombre.Text = txtccNombre.Text
        End If


    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRAlcCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRAlcNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtIRAlcCuenta.Text = txtIRAlcCuenta.Text
            txtIRAlcNombre.Text = txtIRAlcNombre.Text
        End If


    End Sub


    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRPagoAlcCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRPagoAlcNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtIRPagoAlcCuenta.Text = txtIRPagoAlcCuenta.Text
            txtIRPagoAlcNombre.Text = txtIRPagoAlcNombre.Text
        End If
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click

        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRCompContCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRCompContNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtIRCompContCuenta.Text = txtIRCompContCuenta.Text
            txtIRCompContNombre.Text = txtIRCompContNombre.Text
        End If

    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click


        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtIRAlcCompCredCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtIRAlcCompCredNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtIRAlcCompCredCuenta.Text = txtIRAlcCompCredCuenta.Text
            txtIRAlcCompCredNombre.Text = txtIRAlcCompCredNombre.Text
        End If


    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        Dim F As New frmCuentasAsignar
        F.ShowDialog()

        F.lblGrupo.Text = 1

        If F.lblSalir.Text = 1 Then
            Me.txtdevolucioncuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            Me.txtdevolucionnombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)

        Else
            txtdevolucioncuenta.Text = txtdevolucioncuenta.Text
            txtdevolucionnombre.Text = txtdevolucionnombre.Text
        End If
    End Sub
End Class


'Dim F As New frmCuentasBuscar()
'        F.ShowDialog()
'        If F.lblSalir.Text = 1 Then
'            txtIRCuenta.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
'            txtIRNombre.Text = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
'        Else
'            txtIRCuenta.Text = txtIRCuenta.Text
'            txtIRNombre.Text = txtIRNombre.Text
'        End If
