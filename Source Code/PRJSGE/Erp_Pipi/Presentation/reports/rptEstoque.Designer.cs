namespace Presentation.reports
{
    partial class rptEstoque
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
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.dsRelatorio1 = new Presentation.reports.dsRelatorio();
            this.tblEstoqueTableAdapter = new Presentation.reports.dsRelatorioTableAdapters.tblEstoqueTableAdapter();
            this.vCustoTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.vLucroUnitario = new DevExpress.XtraReports.UI.CalculatedField();
            this.vLucroTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.lucroSobreFaturado = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.xrLabel18,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel12,
            this.xrLabel10,
            this.xrLine2,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel13,
            this.xrLabel11,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.Height = 233;
            this.Detail.Name = "Detail";
            // 
            // xrLabel18
            // 
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.vLucroTotal", "{0:n2}")});
            this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel18.Location = new System.Drawing.Point(150, 92);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.Size = new System.Drawing.Size(100, 17);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.Text = "xrLabel18";
            this.xrLabel18.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.vLucroUnitario", "{0:n2}")});
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel15.Location = new System.Drawing.Point(567, 117);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.Size = new System.Drawing.Size(100, 17);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.WordWrap = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.FLTVALORVENDAUNITARIO", "{0:n2}")});
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel14.Location = new System.Drawing.Point(567, 92);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.Size = new System.Drawing.Size(100, 17);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "xrLabel14";
            this.xrLabel14.WordWrap = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.FLTVALORCUSTOUNITARIO", "{0:n2}")});
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel12.Location = new System.Drawing.Point(567, 67);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.Size = new System.Drawing.Size(100, 17);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "xrLabel12";
            this.xrLabel12.WordWrap = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.vCustoTotal", "{0:n2}")});
            this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel10.Location = new System.Drawing.Point(150, 67);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.Size = new System.Drawing.Size(100, 17);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            this.xrLabel10.WordWrap = false;
            // 
            // xrLine2
            // 
            this.xrLine2.Location = new System.Drawing.Point(0, 192);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.Size = new System.Drawing.Size(733, 8);
            // 
            // xrLabel17
            // 
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.Location = new System.Drawing.Point(0, 92);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.Size = new System.Drawing.Size(133, 17);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.Text = "Valor de lucro total:";
            this.xrLabel17.WordWrap = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.Location = new System.Drawing.Point(0, 67);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.Size = new System.Drawing.Size(133, 17);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "Valor de custo total:";
            this.xrLabel16.WordWrap = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.Location = new System.Drawing.Point(433, 117);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.Size = new System.Drawing.Size(125, 17);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "Vl. Lucro unitário:";
            this.xrLabel13.WordWrap = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.Location = new System.Drawing.Point(433, 92);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.Size = new System.Drawing.Size(125, 17);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "Vl. Venda unitário:";
            this.xrLabel11.WordWrap = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.Location = new System.Drawing.Point(433, 67);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.Size = new System.Drawing.Size(100, 17);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Custo unitário:";
            this.xrLabel9.WordWrap = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.DTEENTRADA", "{0:dd/MM/yyyy}")});
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.Location = new System.Drawing.Point(567, 8);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.Size = new System.Drawing.Size(100, 17);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.Location = new System.Drawing.Point(433, 8);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.Size = new System.Drawing.Size(117, 17);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "Data de entrada:";
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.INTQUANTIDADEENTRADA", "{0} unidades")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.Location = new System.Drawing.Point(567, 33);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.Size = new System.Drawing.Size(100, 17);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.Location = new System.Drawing.Point(433, 33);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.Size = new System.Drawing.Size(117, 17);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Quantidade atual:";
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.ID_PRODUTO", "")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xrLabel4.Location = new System.Drawing.Point(67, 8);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.Size = new System.Drawing.Size(100, 17);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.Location = new System.Drawing.Point(0, 8);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.Size = new System.Drawing.Size(58, 17);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Código:";
            this.xrLabel3.WordWrap = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.STRNOME", "")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.Location = new System.Drawing.Point(67, 33);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(100, 17);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.WordWrap = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.Location = new System.Drawing.Point(0, 33);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(67, 17);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Produto:";
            this.xrLabel1.WordWrap = false;
            // 
            // dsRelatorio1
            // 
            this.dsRelatorio1.DataSetName = "dsRelatorio";
            this.dsRelatorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEstoqueTableAdapter
            // 
            this.tblEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // vCustoTotal
            // 
            this.vCustoTotal.DataMember = "tblEstoque";
            this.vCustoTotal.DataSource = this.dsRelatorio1;
            this.vCustoTotal.DisplayName = "vCustoTotal";
            this.vCustoTotal.Expression = "[FLTVALORCUSTOUNITARIO] * ([INTQUANTIDADEENTRADA] - [INTQUANTIDADEVENDIDA])";
            this.vCustoTotal.Name = "vCustoTotal";
            // 
            // vLucroUnitario
            // 
            this.vLucroUnitario.DataMember = "tblEstoque";
            this.vLucroUnitario.DataSource = this.dsRelatorio1;
            this.vLucroUnitario.DisplayName = "vLucroUnitario";
            this.vLucroUnitario.Expression = "[FLTVALORVENDAUNITARIO] - [FLTVALORCUSTOUNITARIO]";
            this.vLucroUnitario.Name = "vLucroUnitario";
            // 
            // vLucroTotal
            // 
            this.vLucroTotal.DataMember = "tblEstoque";
            this.vLucroTotal.DataSource = this.dsRelatorio1;
            this.vLucroTotal.DisplayName = "vLucroTotal";
            this.vLucroTotal.Expression = "[INTQUANTIDADEENTRADA] * ([FLTVALORVENDAUNITARIO] - [FLTVALORCUSTOUNITARIO])";
            this.vLucroTotal.Name = "vLucroTotal";
            // 
            // xrPanel1
            // 
            this.xrPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19});
            this.xrPanel1.Location = new System.Drawing.Point(0, 150);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.Size = new System.Drawing.Size(733, 33);
            this.xrPanel1.StylePriority.UseBackColor = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.Location = new System.Drawing.Point(8, 8);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.Size = new System.Drawing.Size(150, 17);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.Text = "Quantidade vendida:";
            this.xrLabel19.WordWrap = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.INTQUANTIDADEVENDIDA", "")});
            this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrLabel20.Location = new System.Drawing.Point(158, 8);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.Size = new System.Drawing.Size(100, 17);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.Text = "xrLabel20";
            this.xrLabel20.WordWrap = false;
            // 
            // xrLabel21
            // 
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.Location = new System.Drawing.Point(325, 8);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.Size = new System.Drawing.Size(267, 17);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "Lucro faturado pela quantidade vendida:";
            this.xrLabel21.WordWrap = false;
            // 
            // lucroSobreFaturado
            // 
            this.lucroSobreFaturado.DataMember = "tblEstoque";
            this.lucroSobreFaturado.DataSource = this.dsRelatorio1;
            this.lucroSobreFaturado.Expression = "([FLTVALORVENDAUNITARIO] - [FLTVALORCUSTOUNITARIO]) * [INTQUANTIDADEVENDIDA]";
            this.lucroSobreFaturado.Name = "lucroSobreFaturado";
            // 
            // xrLabel22
            // 
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblEstoque.lucroSobreFaturado", "{0:n2}")});
            this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xrLabel22.Location = new System.Drawing.Point(592, 8);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.Size = new System.Drawing.Size(100, 17);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "xrLabel22";
            this.xrLabel22.WordWrap = false;
            // 
            // rptEstoque
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.vCustoTotal,
            this.vLucroUnitario,
            this.vLucroTotal,
            this.lucroSobreFaturado});
            this.DataAdapter = this.tblEstoqueTableAdapter;
            this.DataMember = "tblEstoque";
            this.DataSource = this.dsRelatorio1;
            this.Margins = new System.Drawing.Printing.Margins(100, 10, 100, 100);
            this.Version = "8.3";
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private dsRelatorio dsRelatorio1;
        private Presentation.reports.dsRelatorioTableAdapters.tblEstoqueTableAdapter tblEstoqueTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.CalculatedField vCustoTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.CalculatedField vLucroUnitario;
        private DevExpress.XtraReports.UI.CalculatedField vLucroTotal;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.CalculatedField lucroSobreFaturado;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
    }
}
