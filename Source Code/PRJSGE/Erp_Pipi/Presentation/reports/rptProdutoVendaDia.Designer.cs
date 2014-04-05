namespace Presentation.reports
{
    partial class rptProdutoVendaDia
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
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.dsRelatorio1 = new Presentation.reports.dsRelatorio();
            this.tblVendasTableAdapter = new Presentation.reports.dsRelatorioTableAdapters.tblVendasTableAdapter();
            this.tblProdutosVendidosPorDiaTableAdapter = new Presentation.reports.dsRelatorioTableAdapters.tblProdutosVendidosPorDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.Height = 42;
            this.Detail.Name = "Detail";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblProdutosVendidosPorDia.total", "")});
            this.xrLabel3.Location = new System.Drawing.Point(542, 0);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.Size = new System.Drawing.Size(100, 25);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblProdutosVendidosPorDia.quantidade", "")});
            this.xrLabel2.Location = new System.Drawing.Point(300, 0);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(100, 25);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblProdutosVendidosPorDia.produto", "")});
            this.xrLabel1.Location = new System.Drawing.Point(0, 0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(100, 25);
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.WordWrap = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Height = 83;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Height = 27;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // dsRelatorio1
            // 
            this.dsRelatorio1.DataSetName = "dsRelatorio";
            this.dsRelatorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVendasTableAdapter
            // 
            this.tblVendasTableAdapter.ClearBeforeFill = true;
            // 
            // tblProdutosVendidosPorDiaTableAdapter
            // 
            this.tblProdutosVendidosPorDiaTableAdapter.ClearBeforeFill = true;
            // 
            // rptProdutoVendaDia
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportFooter,
            this.GroupHeader1});
            this.DataAdapter = this.tblProdutosVendidosPorDiaTableAdapter;
            this.DataMember = "tblProdutosVendidosPorDia";
            this.DataSource = this.dsRelatorio1;
            this.Version = "8.3";
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private dsRelatorio dsRelatorio1;
        private Presentation.reports.dsRelatorioTableAdapters.tblVendasTableAdapter tblVendasTableAdapter;
        private Presentation.reports.dsRelatorioTableAdapters.tblProdutosVendidosPorDiaTableAdapter tblProdutosVendidosPorDiaTableAdapter;
    }
}
