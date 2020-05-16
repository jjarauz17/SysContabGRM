namespace Entities
{
    partial class rptLetraCambio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.VencimientoNombre = new DevExpress.XtraReports.UI.XRLabel();
            this.Vencimiento = new DevExpress.XtraReports.UI.XRLabel();
            this.Fecha = new DevExpress.XtraReports.UI.XRLabel();
            this.FechaNombre = new DevExpress.XtraReports.UI.XRLabel();
            this.EmpresaN = new DevExpress.XtraReports.UI.XRLabel();
            this.ANombre = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.VencimientoNombre,
            this.Vencimiento,
            this.Fecha,
            this.FechaNombre,
            this.EmpresaN,
            this.ANombre});
            this.PageHeader.HeightF = 502.0833F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TCambio", "{0:n4}")});
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(689.5766F, 279.125F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(130.2133F, 25F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "ANombre";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "EnLetras")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(96.87497F, 197.875F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(792.7065F, 25F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "ANombre";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Monto", "{0:n2}")});
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(710.4167F, 29.12496F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(234.3751F, 31.33328F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "ANombre";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // VencimientoNombre
            // 
            this.VencimientoNombre.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "VencimientoNombre")});
            this.VencimientoNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VencimientoNombre.LocationFloat = new DevExpress.Utils.PointFloat(144.7916F, 335.375F);
            this.VencimientoNombre.Name = "VencimientoNombre";
            this.VencimientoNombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.VencimientoNombre.SizeF = new System.Drawing.SizeF(89.58159F, 25F);
            this.VencimientoNombre.StylePriority.UseFont = false;
            this.VencimientoNombre.StylePriority.UseTextAlignment = false;
            this.VencimientoNombre.Text = "ANombre";
            this.VencimientoNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Vencimiento
            // 
            this.Vencimiento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Vencimiento")});
            this.Vencimiento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vencimiento.LocationFloat = new DevExpress.Utils.PointFloat(263.5417F, 335.375F);
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Vencimiento.SizeF = new System.Drawing.SizeF(105.2066F, 25F);
            this.Vencimiento.StylePriority.UseFont = false;
            this.Vencimiento.StylePriority.UseTextAlignment = false;
            this.Vencimiento.Text = "ANombre";
            this.Vencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Fecha
            // 
            this.Fecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Fecha")});
            this.Fecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.LocationFloat = new DevExpress.Utils.PointFloat(96.87497F, 95.79166F);
            this.Fecha.Name = "Fecha";
            this.Fecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Fecha.SizeF = new System.Drawing.SizeF(155.2066F, 25F);
            this.Fecha.StylePriority.UseFont = false;
            this.Fecha.StylePriority.UseTextAlignment = false;
            this.Fecha.Text = "ANombre";
            this.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // FechaNombre
            // 
            this.FechaNombre.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FechaNombre")});
            this.FechaNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNombre.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.79166F);
            this.FechaNombre.Name = "FechaNombre";
            this.FechaNombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.FechaNombre.SizeF = new System.Drawing.SizeF(88.53998F, 25F);
            this.FechaNombre.StylePriority.UseFont = false;
            this.FechaNombre.StylePriority.UseTextAlignment = false;
            this.FechaNombre.Text = "ANombre";
            this.FechaNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // EmpresaN
            // 
            this.EmpresaN.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NEmpresa")});
            this.EmpresaN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpresaN.LocationFloat = new DevExpress.Utils.PointFloat(293.7499F, 149.9584F);
            this.EmpresaN.Name = "EmpresaN";
            this.EmpresaN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.EmpresaN.SizeF = new System.Drawing.SizeF(526.04F, 25F);
            this.EmpresaN.StylePriority.UseFont = false;
            this.EmpresaN.StylePriority.UseTextAlignment = false;
            this.EmpresaN.Text = "ANombre";
            this.EmpresaN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ANombre
            // 
            this.ANombre.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ANombre")});
            this.ANombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANombre.LocationFloat = new DevExpress.Utils.PointFloat(293.7499F, 95.79166F);
            this.ANombre.Name = "ANombre";
            this.ANombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ANombre.SizeF = new System.Drawing.SizeF(526.04F, 25F);
            this.ANombre.StylePriority.UseFont = false;
            this.ANombre.StylePriority.UseTextAlignment = false;
            this.ANombre.Text = "ANombre";
            this.ANombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "VencimientoNombre")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(144.7917F, 373.9166F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(89.58159F, 25F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "ANombre";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Vencimiento")});
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(263.5417F, 373.9166F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(105.2066F, 25F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "ANombre";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NEmpresa")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(418.7518F, 335.375F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(401.0382F, 25F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "ANombre";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NEmpresa")});
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(418.7518F, 373.9166F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(401.0382F, 25F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "ANombre";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // rptLetraCambio
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel EmpresaN;
        private DevExpress.XtraReports.UI.XRLabel ANombre;
        private DevExpress.XtraReports.UI.XRLabel VencimientoNombre;
        private DevExpress.XtraReports.UI.XRLabel Vencimiento;
        private DevExpress.XtraReports.UI.XRLabel Fecha;
        private DevExpress.XtraReports.UI.XRLabel FechaNombre;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    }
}
